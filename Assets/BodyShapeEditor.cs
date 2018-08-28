using UnityEngine;

public class BodyShapeEditor : MonoBehaviour
{
    [SerializeField]
    BodyShape shape;

    void Start()
    {
        shape = new BodyShape(this.gameObject);
    }

    void Update()
    {
        shape.ApplyPoses();
    }

    float totalWeight = 0;
    private Vector2 scrollPosition;

    void OnGUI()
    {
        Rect rect = Rect.MinMaxRect(0, 0, 200, Screen.height);
        GUILayout.BeginArea(rect);
        scrollPosition = GUILayout.BeginScrollView(scrollPosition);
        GUILayout.BeginVertical();
        foreach (var pair in shape.controlMasks)
        {
            int id = pair.Key;
            float weight = shape.GetControlWeight(id);
            GUILayout.BeginHorizontal();
            GUILayout.Label(shape.GetControlCategory(id));
            float newWeight = GUILayout.HorizontalSlider(weight, 0f, 1f, GUILayout.Width(200f));
            if (newWeight != weight)
                shape.SetControlWeight(id, newWeight);
            GUILayout.EndHorizontal();
        }

        if (GUILayout.Button("rand"))
        {
            foreach (var pair in shape.controlMasks)
            {
                int id = pair.Key;
                shape.SetControlWeight(id, Random.Range(0f, 1f));
            }
        }

        GUILayout.Label("total weight");
        float newTotalWeight = GUILayout.HorizontalSlider(totalWeight, 0f, 1f);
        if (newTotalWeight != totalWeight)
        {
            totalWeight = newTotalWeight;
            foreach (var pair in shape.controlMasks)
            {
                int id = pair.Key;
                shape.SetControlWeight(id, totalWeight);
            }
        }

        GUILayout.EndVertical();
        GUILayout.EndScrollView();
        GUILayout.EndArea();
    }
}
