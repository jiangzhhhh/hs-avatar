using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShapeBase
{
    public class Keypose
    {
        public Vector3 pos = Vector3.zero;
        public Vector3 rot = Vector3.zero;
        public Vector3 scale = Vector3.one;
    }

    public class Bone : Keypose
    {
        public Transform trfBone;
    }

    public Dictionary<string, List<Keypose>> keyposes = new Dictionary<string, List<Keypose>>();
    public Dictionary<int, Dictionary<string, bool[,]>> controlMasks = new Dictionary<int, Dictionary<string, bool[,]>>();
    public Dictionary<int, float> controlWeights = new Dictionary<int, float>();
    public Dictionary<int, string[]> controlNames = new Dictionary<int, string[]>();

    public Dictionary<int, Keypose> boneID2SrcPose = new Dictionary<int, Keypose>();
    public Dictionary<int, string> boneID2SrcBoneName = new Dictionary<int, string>();
    public Dictionary<string, int> srcBoneName2BoneID = new Dictionary<string, int>();
    public Dictionary<int, Bone> boneID2DstPose = new Dictionary<int, Bone>();
    public Dictionary<string, int> dstBoneName2BoneID = new Dictionary<string, int>();

    string shapeConfig;
    string keyposeConfig;
    string controlNameConfig;
    public GameObject shapeObject { get; private set; }

    public ShapeBase(GameObject go, string shapeConfig, string anmConfig, string controlNameConfig)
    {
        this.shapeObject = go;
        this.shapeConfig = shapeConfig;
        this.keyposeConfig = anmConfig;
        this.controlNameConfig = controlNameConfig;

        Debug.LogFormat("bone count = {0}", go.transform.GetComponentsInChildren<Transform>().Length);

        InitBoneMapTable();
        ParseShapeControlConfig();
        ParseShapeKeyposes();
        ParseControlNames();

        //set default weights
        foreach (var id in controlMasks.Keys)
            SetControlWeight(id, .5f);
    }

    public float GetControlWeight(int id) { return controlWeights[id]; }
    public void SetControlWeight(int id, float weight)
    {
        controlWeights[id] = weight;
        const int max = 25 - 1;
        int idx = Mathf.FloorToInt(max * weight + .5f);
        idx = Mathf.Clamp(idx, 0, max);

        var maskTable = controlMasks[id];

        foreach (var pair in maskTable)
        {
            string srcBoneName = pair.Key;
            bool[,] mask = pair.Value;

            var frames = keyposes[srcBoneName];
            var pose = frames[idx];

            var src = boneID2SrcPose[srcBoneName2BoneID[srcBoneName]];
            if (mask[0, 0]) src.pos.x = pose.pos.x;
            if (mask[0, 1]) src.pos.y = pose.pos.y;
            if (mask[0, 2]) src.pos.z = pose.pos.z;
            if (mask[1, 0]) src.rot.x = pose.rot.x;
            if (mask[1, 1]) src.rot.y = pose.rot.y;
            if (mask[1, 2]) src.rot.z = pose.rot.z;
            if (mask[2, 0]) src.scale.x = pose.scale.x;
            if (mask[2, 1]) src.scale.y = pose.scale.y;
            if (mask[2, 2]) src.scale.z = pose.scale.z;
        }
    }

    public virtual void ApplyPoses() { }

    void ParseShapeKeyposes()
    {
        var ta = Resources.Load<TextAsset>(this.keyposeConfig);
        if (ta == null)
            return;

        string txt = ta.text.Replace("\r", "");
        string[] lines = txt.Split('\n');
        foreach (var line in lines)
        {
            var vals = line.Split('\t');
            List<Keypose> poses = new List<Keypose>();
            int pos = 0;
            string srcBoneName = vals[pos++];
            if (string.IsNullOrEmpty(srcBoneName))
                continue;
            for (int i = 0; i < 25; ++i)
            {
                int idx = int.Parse(vals[pos++]);
                Keypose frame = new Keypose();
                frame.pos.x = float.Parse(vals[pos++]);
                frame.pos.y = float.Parse(vals[pos++]);
                frame.pos.z = float.Parse(vals[pos++]);
                frame.rot.x = float.Parse(vals[pos++]);
                frame.rot.y = float.Parse(vals[pos++]);
                frame.rot.z = float.Parse(vals[pos++]);
                frame.scale.x = float.Parse(vals[pos++]);
                frame.scale.y = float.Parse(vals[pos++]);
                frame.scale.z = float.Parse(vals[pos++]);
                poses.Add(frame);
            }
            keyposes.Add(srcBoneName, poses);
        }
    }
    void ParseShapeControlConfig()
    {
        var ta = Resources.Load<TextAsset>(this.shapeConfig);
        if (ta == null)
            return;

        string txt = ta.text.Replace("\r", "");
        string[] lines = txt.Split('\n');
        foreach (var line in lines)
        {
            var vals = line.Split('\t');

            int id = 0;
            if (!int.TryParse(vals[0], out id))
                continue;

            Dictionary<string, bool[,]> masks = null;
            if (!controlMasks.TryGetValue(id, out masks))
            {
                masks = new Dictionary<string, bool[,]>();
                controlMasks.Add(id, masks);
            }

            string srcBoneName = vals[1];
            bool[,] mask = new bool[3, 3];
            mask[0, 0] = vals[2] == "1";        //pos.x
            mask[0, 1] = vals[3] == "1";        //pos.y
            mask[0, 2] = vals[4] == "1";        //pos.z
            mask[1, 0] = vals[5] == "1";        //rot.x
            mask[1, 1] = vals[6] == "1";        //rot.y
            mask[1, 2] = vals[7] == "1";        //rot.z
            mask[2, 0] = vals[8] == "1";        //scale.x
            mask[2, 1] = vals[9] == "1";        //scale.y
            mask[2, 2] = vals[10] == "1";       //scale.z
            masks.Add(srcBoneName, mask);
        }

        foreach (int id in controlMasks.Keys)
            controlWeights.Add(id, 0f);
    }

    void ParseControlNames()
    {
        var ta = Resources.Load<TextAsset>(this.controlNameConfig);
        if (ta == null)
            return;

        string txt = ta.text.Replace("\r", "");
        string[] lines = txt.Split('\n');
        foreach (var line in lines)
        {
            var vals = line.Split('\t');
            int id = 0;
            if (!int.TryParse(vals[0], out id))
                continue;
            string category = vals[1];
            string left = vals[2];
            string right = vals[3];
            controlNames.Add(id, new string[3] { category, left, right });
        }
    }

    public string GetControlCategory(int id)
    {
        string[] vals;
        if (controlNames.TryGetValue(id, out vals))
            return vals[0];
        return id.ToString();
    }

    public string GetControlCategoryLeft(int id)
    {
        string[] vals;
        if (controlNames.TryGetValue(id, out vals))
            return vals[1];
        return id.ToString();
    }

    public string GetControlCategoryRight(int id)
    {
        string[] vals;
        if (controlNames.TryGetValue(id, out vals))
            return vals[2];
        return id.ToString();
    }

    protected virtual void InitBoneMapTable() { }
}
