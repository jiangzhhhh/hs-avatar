using System;
using UnityEngine;

[System.Serializable]
public class HeadShape : ShapeBase
{
    public enum DstBoneName
    {
        cf_J_CheekLow_L,
        cf_J_CheekLow_R,
        cf_J_CheekUp_L,
        cf_J_CheekUp_R,
        cf_J_Chin_rs,
        cf_J_ChinLow,
        cf_J_ChinTip_s,
        cf_J_EarBase_s_L,
        cf_J_EarBase_s_R,
        cf_J_EarLow_L,
        cf_J_EarLow_R,
        cf_J_EarRing_L,
        cf_J_EarRing_R,
        cf_J_EarUp_L,
        cf_J_EarUp_R,
        cf_J_Eye_r_L,
        cf_J_Eye_r_R,
        cf_J_eye_rs_L,
        cf_J_eye_rs_R,
        cf_J_Eye_s_L,
        cf_J_Eye_s_R,
        cf_J_Eye_t_L,
        cf_J_Eye_t_R,
        cf_J_Eye01_L,
        cf_J_Eye01_R,
        cf_J_Eye02_L,
        cf_J_Eye02_R,
        cf_J_Eye03_L,
        cf_J_Eye03_R,
        cf_J_Eye04_L,
        cf_J_Eye04_R,
        cf_J_EyePos_rz_L,
        cf_J_EyePos_rz_R,
        cf_J_FaceBase,
        cf_J_FaceLow_s,
        cf_J_FaceLowBase,
        cf_J_FaceUp_ty,
        cf_J_FaceUp_tz,
        cf_J_Mayu_L,
        cf_J_Mayu_R,
        cf_J_MayuMid_s_L,
        cf_J_MayuMid_s_R,
        cf_J_MayuTip_s_L,
        cf_J_MayuTip_s_R,
        cf_J_megane,
        cf_J_Mouth_L,
        cf_J_Mouth_R,
        cf_J_MouthLow,
        cf_J_Mouthup,
        cf_J_MouthBase_s,
        cf_J_MouthBase_tr,
        cf_J_Nose_t,
        cf_J_Nose_tip,
        cf_J_NoseBase_s,
        cf_J_NoseBase_trs,
        cf_J_NoseBridge_s,
        cf_J_NoseBridge_t,
        cf_J_NoseWing_tx_L,
        cf_J_NoseWing_tx_R,
        cf_J_pupil_s_L,
        cf_J_pupil_s_R,
        cf_J_MouthCavity
    }

    public enum SrcBoneName
    {
        cf_s_CheekLow_tx_L,
        cf_s_CheekLow_tx_R,
        cf_s_CheekLow_ty,
        cf_s_CheekLow_tz,
        cf_s_CheekUp_tx_L,
        cf_s_CheekUp_tx_R,
        cf_s_CheekUp_ty,
        cf_s_CheekUp_tz_00,
        cf_s_CheekUp_tz_01,
        cf_s_Chin_rx,
        cf_s_Chin_sx,
        cf_s_Chin_ty,
        cf_s_Chin_tz,
        cf_s_ChinLow,
        cf_s_ChinTip_sx,
        cf_s_ChinTip_ty,
        cf_s_ChinTip_tz,
        cf_s_EarBase_ry_L,
        cf_s_EarBase_ry_R,
        cf_s_EarBase_rz_L,
        cf_s_EarBase_rz_R,
        cf_s_EarBase_s_L,
        cf_s_EarBase_s_R,
        cf_s_EarLow_L,
        cf_s_EarLow_R,
        cf_s_EarRing_L,
        cf_s_EarRing_R,
        cf_s_EarRing_rz_L,
        cf_s_EarRing_rz_R,
        cf_s_EarRing_s_L,
        cf_s_EarRing_s_R,
        cf_s_EarUp_L,
        cf_s_EarUp_R,
        cf_s_Eye_ry_L,
        cf_s_Eye_ry_R,
        cf_s_Eye_rz_L,
        cf_s_Eye_rz_R,
        cf_s_Eye_sx_L,
        cf_s_Eye_sx_R,
        cf_s_Eye_sy_L,
        cf_s_Eye_sy_R,
        cf_s_Eye_tx_L,
        cf_s_Eye_tx_R,
        cf_s_Eye_ty,
        cf_s_Eye_tz,
        cf_s_Eye01_L,
        cf_s_Eye01_R,
        cf_s_Eye01_rx_L,
        cf_s_Eye01_rx_R,
        cf_s_Eye02_L,
        cf_s_Eye02_R,
        cf_s_Eye02_ry_L,
        cf_s_Eye02_ry_R,
        cf_s_Eye03_L,
        cf_s_Eye03_R,
        cf_s_Eye03_rx_L,
        cf_s_Eye03_rx_R,
        cf_s_Eye04_L,
        cf_s_Eye04_R,
        cf_s_Eye04_ry_L,
        cf_s_Eye04_ry_R,
        cf_s_EyePos_L,
        cf_s_EyePos_R,
        cf_s_EyePos_rz_L,
        cf_s_EyePos_rz_R,
        cf_s_FaceBase_sx,
        cf_s_FaceLow_sx,
        cf_s_FaceLow_tz,
        cf_s_FaceUp_ty,
        cf_s_FaceUp_tz,
        cf_s_Mayu_L,
        cf_s_Mayu_R,
        cf_s_Mayu_tx_L,
        cf_s_Mayu_tx_R,
        cf_s_Mayu_ty,
        cf_s_Mayu02_L,
        cf_s_Mayu02_R,
        cf_s_MayuMid_s_L,
        cf_s_MayuMid_s_R,
        cf_s_MayuTip_s_L,
        cf_s_MayuTip_s_R,
        cf_s_megane_rx_nosebridge,
        cf_s_megane_ty_eye,
        cf_s_megane_ty_nose,
        cf_s_megane_tz_nosebridge,
        cf_s_MouthBase_tz,
        cf_s_Mouthup,
        cf_s_Mouth_L,
        cf_s_Mouth_R,
        cf_s_MouthBase_sx,
        cf_s_MouthBase_sy,
        cf_s_MouthBase_ty,
        cf_s_MouthLow,
        cf_s_Nose_rx,
        cf_s_Nose_tip,
        cf_s_Nose_tz,
        cf_s_NoseBase,
        cf_s_NoseBase_rx,
        cf_s_NoseBase_sx,
        cf_s_NoseBase_ty,
        cf_s_NoseBase_tz,
        cf_s_NoseBridge_rx,
        cf_s_NoseBridge_sx,
        cf_s_NoseBridge_ty,
        cf_s_NoseBridge_tz_00,
        cf_s_NoseBridge_tz_01,
        cf_s_NoseWing_rx,
        cf_s_NoseWing_rz_L,
        cf_s_NoseWing_rz_R,
        cf_s_NoseWing_tx_L,
        cf_s_NoseWing_tx_R,
        cf_s_NoseWing_ty,
        cf_s_NoseWing_tz,
        cf_s_pupil_ssx_L,
        cf_s_pupil_ssx_R,
        cf_s_pupil_ssy_L,
        cf_s_pupil_ssy_R,
        cf_s_pupil_sx_L,
        cf_s_pupil_sx_R,
        cf_s_pupil_sy_L,
        cf_s_pupil_sy_R,
        cf_s_MouthC_ty,
        cf_s_MouthC_tz,
        cf_s_MayuMid_ftz,
        cf_s_MayuMid_ntz,
        cf_s_MayuMidre_tz,
        cf_s_MayuTip_esx
    }

    public HeadShape(GameObject go)
        : base(go, "cf_customhead", "cf_anmShapeHead_02", "")
    {
    }

    protected override void InitBoneMapTable()
    {
        foreach (var boneIdx in Enum.GetValues(typeof(SrcBoneName)))
        {
            Keypose pose = new Keypose();
            boneID2SrcPose.Add((int)boneIdx, pose);
            boneID2SrcBoneName.Add((int)boneIdx, Enum.GetName(typeof(SrcBoneName), boneIdx));
            srcBoneName2BoneID.Add(Enum.GetName(typeof(SrcBoneName), boneIdx), (int)boneIdx);
        }

        foreach (var boneIdx in Enum.GetValues(typeof(DstBoneName)))
        {
            string dstBoneName = Enum.GetName(typeof(DstBoneName), boneIdx);
            Transform tf = this.shapeObject.transform.FindLoop(dstBoneName);
            if (tf == null)
            {
                Debug.LogErrorFormat("Cant find bone:{0}", dstBoneName);
                var tmp = new GameObject(dstBoneName);
                tf = tmp.transform;
            }

            Bone bone = new Bone();
            bone.trfBone = tf;
            bone.pos = tf.localPosition;
            bone.rot = tf.localRotation.eulerAngles;
            bone.scale = tf.localScale;

            boneID2DstPose.Add((int)boneIdx, bone);
            dstBoneName2BoneID.Add(dstBoneName, (int)boneIdx);
        }
    }

    public override void ApplyPoses()
    {
        this.boneID2DstPose[61].trfBone.SetLocalPositionY(this.boneID2SrcPose[121].pos.y);
        this.boneID2DstPose[61].trfBone.SetLocalPositionZ(this.boneID2SrcPose[122].pos.z + this.boneID2SrcPose[121].pos.z);
        this.boneID2DstPose[38].trfBone.SetLocalPositionX(this.boneID2SrcPose[72].pos.x);
        this.boneID2DstPose[38].trfBone.SetLocalPositionY(this.boneID2SrcPose[74].pos.y);
        this.boneID2DstPose[38].trfBone.SetLocalPositionZ(this.boneID2SrcPose[74].pos.z + this.boneID2SrcPose[70].pos.z + this.boneID2SrcPose[72].pos.z + this.boneID2SrcPose[75].pos.z);
        this.boneID2DstPose[38].trfBone.SetLocalRotation(this.boneID2SrcPose[74].rot.x + this.boneID2SrcPose[70].rot.x + this.boneID2SrcPose[75].rot.x, this.boneID2SrcPose[70].rot.y + this.boneID2SrcPose[72].rot.y, this.boneID2SrcPose[70].rot.z);
        this.boneID2DstPose[39].trfBone.SetLocalPositionX(this.boneID2SrcPose[73].pos.x);
        this.boneID2DstPose[39].trfBone.SetLocalPositionY(this.boneID2SrcPose[74].pos.y);
        this.boneID2DstPose[39].trfBone.SetLocalPositionZ(this.boneID2SrcPose[74].pos.z + this.boneID2SrcPose[71].pos.z + this.boneID2SrcPose[73].pos.z + this.boneID2SrcPose[76].pos.z);
        this.boneID2DstPose[39].trfBone.SetLocalRotation(this.boneID2SrcPose[74].rot.x + this.boneID2SrcPose[71].rot.x + this.boneID2SrcPose[76].rot.x, this.boneID2SrcPose[71].rot.y + this.boneID2SrcPose[73].rot.y, this.boneID2SrcPose[71].rot.z);
        this.boneID2DstPose[40].trfBone.SetLocalPositionY(this.boneID2SrcPose[77].pos.y);
        this.boneID2DstPose[40].trfBone.SetLocalPositionZ(this.boneID2SrcPose[77].pos.z + this.boneID2SrcPose[123].pos.z + this.boneID2SrcPose[124].pos.z + this.boneID2SrcPose[125].pos.z);
        this.boneID2DstPose[40].trfBone.SetLocalRotation(this.boneID2SrcPose[77].rot.x + this.boneID2SrcPose[123].rot.x + this.boneID2SrcPose[124].rot.x + this.boneID2SrcPose[125].rot.x, this.boneID2SrcPose[77].rot.y + this.boneID2SrcPose[125].rot.y, this.boneID2SrcPose[77].rot.z);
        this.boneID2DstPose[41].trfBone.SetLocalPositionY(this.boneID2SrcPose[78].pos.y);
        this.boneID2DstPose[41].trfBone.SetLocalPositionZ(this.boneID2SrcPose[78].pos.z + this.boneID2SrcPose[123].pos.z + this.boneID2SrcPose[124].pos.z + this.boneID2SrcPose[125].pos.z);
        this.boneID2DstPose[41].trfBone.SetLocalRotation(this.boneID2SrcPose[78].rot.x + this.boneID2SrcPose[123].rot.x + this.boneID2SrcPose[124].rot.x + this.boneID2SrcPose[125].rot.x, this.boneID2SrcPose[78].rot.y - this.boneID2SrcPose[125].rot.y, this.boneID2SrcPose[78].rot.z);
        this.boneID2DstPose[42].trfBone.SetLocalPositionY(this.boneID2SrcPose[79].pos.y);
        this.boneID2DstPose[42].trfBone.SetLocalPositionZ(this.boneID2SrcPose[79].pos.z + this.boneID2SrcPose[126].pos.z);
        this.boneID2DstPose[42].trfBone.SetLocalRotation(this.boneID2SrcPose[79].rot.x + this.boneID2SrcPose[126].rot.x, this.boneID2SrcPose[79].rot.y, this.boneID2SrcPose[79].rot.z);
        this.boneID2DstPose[43].trfBone.SetLocalPositionY(this.boneID2SrcPose[80].pos.y);
        this.boneID2DstPose[43].trfBone.SetLocalPositionZ(this.boneID2SrcPose[80].pos.z + this.boneID2SrcPose[126].pos.z);
        this.boneID2DstPose[43].trfBone.SetLocalRotation(this.boneID2SrcPose[80].rot.x + this.boneID2SrcPose[126].rot.x, this.boneID2SrcPose[80].rot.y, this.boneID2SrcPose[80].rot.z);
        this.boneID2DstPose[21].trfBone.SetLocalPositionX(this.boneID2SrcPose[41].pos.x);
        this.boneID2DstPose[21].trfBone.SetLocalPositionY(this.boneID2SrcPose[43].pos.y);
        this.boneID2DstPose[21].trfBone.SetLocalPositionZ(this.boneID2SrcPose[44].pos.z);
        this.boneID2DstPose[21].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[35].rot.z);
        this.boneID2DstPose[22].trfBone.SetLocalPositionX(this.boneID2SrcPose[42].pos.x);
        this.boneID2DstPose[22].trfBone.SetLocalPositionY(this.boneID2SrcPose[43].pos.y);
        this.boneID2DstPose[22].trfBone.SetLocalPositionZ(this.boneID2SrcPose[44].pos.z);
        this.boneID2DstPose[22].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[36].rot.z);
        this.boneID2DstPose[19].trfBone.SetLocalScale(this.boneID2SrcPose[37].scale.x, this.boneID2SrcPose[39].scale.y, 1f);
        this.boneID2DstPose[15].trfBone.SetLocalRotation(0f, this.boneID2SrcPose[33].rot.y, 0f);
        this.boneID2DstPose[20].trfBone.SetLocalScale(this.boneID2SrcPose[38].scale.x, this.boneID2SrcPose[40].scale.y, 1f);
        this.boneID2DstPose[16].trfBone.SetLocalRotation(0f, this.boneID2SrcPose[34].rot.y, 0f);
        this.boneID2DstPose[23].trfBone.SetLocalRotation(this.boneID2SrcPose[47].rot.x, this.boneID2SrcPose[45].rot.y + this.boneID2SrcPose[47].rot.y, 0f);
        this.boneID2DstPose[25].trfBone.SetLocalRotation(this.boneID2SrcPose[49].rot.x, this.boneID2SrcPose[51].rot.y, this.boneID2SrcPose[51].rot.z);
        this.boneID2DstPose[27].trfBone.SetLocalPositionX(this.boneID2SrcPose[53].pos.x);
        this.boneID2DstPose[27].trfBone.SetLocalRotation(this.boneID2SrcPose[55].rot.x, this.boneID2SrcPose[53].rot.y, 0f);
        this.boneID2DstPose[29].trfBone.SetLocalRotation(this.boneID2SrcPose[57].rot.x, this.boneID2SrcPose[59].rot.y, this.boneID2SrcPose[59].rot.z);
        this.boneID2DstPose[24].trfBone.SetLocalRotation(this.boneID2SrcPose[48].rot.x, this.boneID2SrcPose[46].rot.y + this.boneID2SrcPose[48].rot.y, 0f);
        this.boneID2DstPose[26].trfBone.SetLocalRotation(this.boneID2SrcPose[50].rot.x, this.boneID2SrcPose[52].rot.y, this.boneID2SrcPose[52].rot.z);
        this.boneID2DstPose[28].trfBone.SetLocalPositionX(this.boneID2SrcPose[54].pos.x);
        this.boneID2DstPose[28].trfBone.SetLocalRotation(this.boneID2SrcPose[56].rot.x, this.boneID2SrcPose[54].rot.y, 0f);
        this.boneID2DstPose[30].trfBone.SetLocalRotation(this.boneID2SrcPose[58].rot.x, this.boneID2SrcPose[60].rot.y, this.boneID2SrcPose[60].rot.z);
        this.boneID2DstPose[31].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[63].rot.z);
        this.boneID2DstPose[17].trfBone.SetLocalRotation(this.boneID2SrcPose[61].rot.x, 0f, 0f);
        this.boneID2DstPose[32].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[64].rot.z);
        this.boneID2DstPose[18].trfBone.SetLocalRotation(this.boneID2SrcPose[62].rot.x, 0f, 0f);
        this.boneID2DstPose[59].trfBone.SetLocalPositionY(this.boneID2SrcPose[119].pos.y);
        this.boneID2DstPose[59].trfBone.SetLocalPositionZ(this.boneID2SrcPose[113].pos.z + this.boneID2SrcPose[115].pos.z + this.boneID2SrcPose[117].pos.z + this.boneID2SrcPose[119].pos.z);
        this.boneID2DstPose[59].trfBone.SetLocalScale(this.boneID2SrcPose[113].scale.x * this.boneID2SrcPose[115].scale.x * this.boneID2SrcPose[117].scale.x, this.boneID2SrcPose[113].scale.y * this.boneID2SrcPose[115].scale.y * this.boneID2SrcPose[119].scale.y, this.boneID2SrcPose[117].scale.z * this.boneID2SrcPose[119].scale.z);
        this.boneID2DstPose[60].trfBone.SetLocalPositionY(this.boneID2SrcPose[120].pos.y);
        this.boneID2DstPose[60].trfBone.SetLocalPositionZ(this.boneID2SrcPose[114].pos.z + this.boneID2SrcPose[116].pos.z + this.boneID2SrcPose[118].pos.z + this.boneID2SrcPose[120].pos.z);
        this.boneID2DstPose[60].trfBone.SetLocalScale(this.boneID2SrcPose[114].scale.x * this.boneID2SrcPose[116].scale.x * this.boneID2SrcPose[118].scale.x, this.boneID2SrcPose[114].scale.y * this.boneID2SrcPose[116].scale.y * this.boneID2SrcPose[120].scale.y, this.boneID2SrcPose[118].scale.z * this.boneID2SrcPose[120].scale.z);
        this.boneID2DstPose[33].trfBone.SetLocalScale(this.boneID2SrcPose[65].scale.x, 1f, 1f);
        this.boneID2DstPose[36].trfBone.SetLocalPositionY(this.boneID2SrcPose[68].pos.y);
        this.boneID2DstPose[37].trfBone.SetLocalPositionZ(this.boneID2SrcPose[69].pos.z);
        this.boneID2DstPose[2].trfBone.SetLocalPositionX(this.boneID2SrcPose[4].pos.x);
        this.boneID2DstPose[2].trfBone.SetLocalPositionY(this.boneID2SrcPose[6].pos.y);
        this.boneID2DstPose[2].trfBone.SetLocalPositionZ(this.boneID2SrcPose[7].pos.z + this.boneID2SrcPose[8].pos.z);
        this.boneID2DstPose[3].trfBone.SetLocalPositionX(this.boneID2SrcPose[5].pos.x);
        this.boneID2DstPose[3].trfBone.SetLocalPositionY(this.boneID2SrcPose[6].pos.y);
        this.boneID2DstPose[3].trfBone.SetLocalPositionZ(this.boneID2SrcPose[7].pos.z + this.boneID2SrcPose[8].pos.z);
        this.boneID2DstPose[0].trfBone.SetLocalPositionX(this.boneID2SrcPose[0].pos.x);
        this.boneID2DstPose[0].trfBone.SetLocalPositionY(this.boneID2SrcPose[2].pos.y);
        this.boneID2DstPose[0].trfBone.SetLocalPositionZ(this.boneID2SrcPose[3].pos.z);
        this.boneID2DstPose[1].trfBone.SetLocalPositionX(this.boneID2SrcPose[1].pos.x);
        this.boneID2DstPose[1].trfBone.SetLocalPositionY(this.boneID2SrcPose[2].pos.y);
        this.boneID2DstPose[1].trfBone.SetLocalPositionZ(this.boneID2SrcPose[3].pos.z);
        this.boneID2DstPose[35].trfBone.SetLocalPositionZ(this.boneID2SrcPose[67].pos.z);
        this.boneID2DstPose[34].trfBone.SetLocalScale(this.boneID2SrcPose[66].scale.x, 1f, 1f);
        this.boneID2DstPose[50].trfBone.SetLocalPositionY(this.boneID2SrcPose[91].pos.y);
        this.boneID2DstPose[50].trfBone.SetLocalPositionZ(this.boneID2SrcPose[91].pos.z + this.boneID2SrcPose[85].pos.z);
        this.boneID2DstPose[49].trfBone.SetLocalScale(this.boneID2SrcPose[89].scale.x, this.boneID2SrcPose[90].scale.y, 1f);
        this.boneID2DstPose[48].trfBone.SetLocalPositionY(this.boneID2SrcPose[86].pos.y);
        this.boneID2DstPose[47].trfBone.SetLocalPositionY(this.boneID2SrcPose[92].pos.y);
        this.boneID2DstPose[47].trfBone.SetLocalPositionZ(this.boneID2SrcPose[92].pos.z);
        this.boneID2DstPose[47].trfBone.SetLocalScale(this.boneID2SrcPose[92].scale.x, 1f, 1f);
        this.boneID2DstPose[45].trfBone.SetLocalPositionY(this.boneID2SrcPose[87].pos.y);
        this.boneID2DstPose[45].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[87].rot.z);
        this.boneID2DstPose[46].trfBone.SetLocalPositionY(this.boneID2SrcPose[88].pos.y);
        this.boneID2DstPose[46].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[88].rot.z);
        this.boneID2DstPose[5].trfBone.SetLocalPositionY(this.boneID2SrcPose[13].pos.y);
        this.boneID2DstPose[4].trfBone.SetLocalPositionY(this.boneID2SrcPose[11].pos.y + this.boneID2SrcPose[9].pos.y);
        this.boneID2DstPose[4].trfBone.SetLocalPositionZ(this.boneID2SrcPose[12].pos.z + this.boneID2SrcPose[9].pos.z);
        this.boneID2DstPose[4].trfBone.SetLocalRotation(this.boneID2SrcPose[9].rot.x, 0f, 0f);
        this.boneID2DstPose[4].trfBone.SetLocalScale(this.boneID2SrcPose[10].scale.x, 1f, 1f);
        this.boneID2DstPose[6].trfBone.SetLocalPositionY(this.boneID2SrcPose[15].pos.y);
        this.boneID2DstPose[6].trfBone.SetLocalPositionZ(this.boneID2SrcPose[16].pos.z);
        this.boneID2DstPose[6].trfBone.SetLocalScale(this.boneID2SrcPose[14].scale.x, this.boneID2SrcPose[14].scale.y, this.boneID2SrcPose[14].scale.z);
        this.boneID2DstPose[56].trfBone.SetLocalPositionY(this.boneID2SrcPose[103].pos.y);
        this.boneID2DstPose[56].trfBone.SetLocalPositionZ(this.boneID2SrcPose[104].pos.z + this.boneID2SrcPose[105].pos.z + this.boneID2SrcPose[103].pos.z + this.boneID2SrcPose[101].pos.z);
        this.boneID2DstPose[56].trfBone.SetLocalRotation(this.boneID2SrcPose[101].rot.x, 0f, 0f);
        this.boneID2DstPose[55].trfBone.SetLocalScale(this.boneID2SrcPose[102].scale.x, 1f, 1f);
        this.boneID2DstPose[54].trfBone.SetLocalPositionY(this.boneID2SrcPose[97].pos.y + this.boneID2SrcPose[99].pos.y + this.boneID2SrcPose[96].pos.y);
        this.boneID2DstPose[54].trfBone.SetLocalPositionZ(this.boneID2SrcPose[97].pos.z + this.boneID2SrcPose[100].pos.z + this.boneID2SrcPose[96].pos.z);
        this.boneID2DstPose[53].trfBone.SetLocalRotation(this.boneID2SrcPose[97].rot.x + this.boneID2SrcPose[96].rot.x, 0f, 0f);
        this.boneID2DstPose[53].trfBone.SetLocalScale(this.boneID2SrcPose[98].scale.x, this.boneID2SrcPose[98].scale.y, this.boneID2SrcPose[98].scale.z);
        this.boneID2DstPose[57].trfBone.SetLocalPositionX(this.boneID2SrcPose[109].pos.x);
        this.boneID2DstPose[57].trfBone.SetLocalPositionY(this.boneID2SrcPose[111].pos.y);
        this.boneID2DstPose[57].trfBone.SetLocalPositionZ(this.boneID2SrcPose[112].pos.z);
        this.boneID2DstPose[57].trfBone.SetLocalRotation(this.boneID2SrcPose[106].rot.x, 0f, this.boneID2SrcPose[107].rot.z);
        this.boneID2DstPose[58].trfBone.SetLocalPositionX(this.boneID2SrcPose[110].pos.x);
        this.boneID2DstPose[58].trfBone.SetLocalPositionY(this.boneID2SrcPose[111].pos.y);
        this.boneID2DstPose[58].trfBone.SetLocalPositionZ(this.boneID2SrcPose[112].pos.z);
        this.boneID2DstPose[58].trfBone.SetLocalRotation(this.boneID2SrcPose[106].rot.x, 0f, this.boneID2SrcPose[108].rot.z);
        this.boneID2DstPose[52].trfBone.SetLocalPositionY(this.boneID2SrcPose[94].pos.y);
        this.boneID2DstPose[52].trfBone.SetLocalPositionZ(this.boneID2SrcPose[94].pos.z);
        this.boneID2DstPose[52].trfBone.SetLocalScale(this.boneID2SrcPose[94].scale.x, this.boneID2SrcPose[94].scale.y, this.boneID2SrcPose[94].scale.z);
        this.boneID2DstPose[51].trfBone.SetLocalPositionY(this.boneID2SrcPose[93].pos.y);
        this.boneID2DstPose[51].trfBone.SetLocalPositionZ(this.boneID2SrcPose[95].pos.z);
        this.boneID2DstPose[51].trfBone.SetLocalRotation(this.boneID2SrcPose[93].rot.x, 0f, 0f);
        this.boneID2DstPose[44].trfBone.SetLocalPositionY(this.boneID2SrcPose[83].pos.y + this.boneID2SrcPose[81].pos.y + this.boneID2SrcPose[82].pos.y);
        this.boneID2DstPose[44].trfBone.SetLocalPositionZ(this.boneID2SrcPose[83].pos.z + this.boneID2SrcPose[84].pos.z + this.boneID2SrcPose[82].pos.z);
        this.boneID2DstPose[44].trfBone.SetLocalRotation(this.boneID2SrcPose[83].rot.x + this.boneID2SrcPose[81].rot.x + this.boneID2SrcPose[82].rot.x, 0f, 0f);
        this.boneID2DstPose[7].trfBone.SetLocalRotation(0f, this.boneID2SrcPose[17].rot.y, this.boneID2SrcPose[19].rot.z);
        this.boneID2DstPose[7].trfBone.SetLocalScale(this.boneID2SrcPose[21].scale.x, this.boneID2SrcPose[21].scale.y, this.boneID2SrcPose[21].scale.z);
        this.boneID2DstPose[13].trfBone.SetLocalPositionX(this.boneID2SrcPose[31].pos.x);
        this.boneID2DstPose[13].trfBone.SetLocalPositionY(this.boneID2SrcPose[31].pos.y);
        this.boneID2DstPose[13].trfBone.SetLocalPositionZ(this.boneID2SrcPose[31].pos.z);
        this.boneID2DstPose[13].trfBone.SetLocalRotation(this.boneID2SrcPose[31].rot.x, this.boneID2SrcPose[31].rot.y, 0f);
        this.boneID2DstPose[13].trfBone.SetLocalScale(this.boneID2SrcPose[31].scale.x, this.boneID2SrcPose[31].scale.y, this.boneID2SrcPose[31].scale.z);
        this.boneID2DstPose[9].trfBone.SetLocalPositionY(this.boneID2SrcPose[23].pos.y);
        this.boneID2DstPose[9].trfBone.SetLocalPositionZ(this.boneID2SrcPose[23].pos.z);
        this.boneID2DstPose[9].trfBone.SetLocalScale(this.boneID2SrcPose[23].scale.x, this.boneID2SrcPose[23].scale.y, this.boneID2SrcPose[23].scale.z);
        this.boneID2DstPose[8].trfBone.SetLocalRotation(0f, this.boneID2SrcPose[18].rot.y, this.boneID2SrcPose[20].rot.z);
        this.boneID2DstPose[8].trfBone.SetLocalScale(this.boneID2SrcPose[22].scale.x, this.boneID2SrcPose[22].scale.y, this.boneID2SrcPose[22].scale.z);
        this.boneID2DstPose[14].trfBone.SetLocalPositionX(this.boneID2SrcPose[32].pos.x);
        this.boneID2DstPose[14].trfBone.SetLocalPositionY(this.boneID2SrcPose[32].pos.y);
        this.boneID2DstPose[14].trfBone.SetLocalPositionZ(this.boneID2SrcPose[32].pos.z);
        this.boneID2DstPose[14].trfBone.SetLocalRotation(this.boneID2SrcPose[32].rot.x, this.boneID2SrcPose[32].rot.y, 0f);
        this.boneID2DstPose[14].trfBone.SetLocalScale(this.boneID2SrcPose[32].scale.x, this.boneID2SrcPose[32].scale.y, this.boneID2SrcPose[32].scale.z);
        this.boneID2DstPose[10].trfBone.SetLocalPositionY(this.boneID2SrcPose[24].pos.y);
        this.boneID2DstPose[10].trfBone.SetLocalPositionZ(this.boneID2SrcPose[24].pos.z);
        this.boneID2DstPose[10].trfBone.SetLocalScale(this.boneID2SrcPose[24].scale.x, this.boneID2SrcPose[24].scale.y, this.boneID2SrcPose[24].scale.z);
        this.boneID2DstPose[11].trfBone.SetLocalPositionY(this.boneID2SrcPose[25].pos.y);
        this.boneID2DstPose[11].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[27].rot.z);
        this.boneID2DstPose[11].trfBone.SetLocalScale(this.boneID2SrcPose[29].scale.x, this.boneID2SrcPose[29].scale.y, this.boneID2SrcPose[29].scale.z);
        this.boneID2DstPose[12].trfBone.SetLocalPositionY(this.boneID2SrcPose[26].pos.y);
        this.boneID2DstPose[12].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[28].rot.z);
        this.boneID2DstPose[12].trfBone.SetLocalScale(this.boneID2SrcPose[30].scale.x, this.boneID2SrcPose[30].scale.y, this.boneID2SrcPose[30].scale.z);
    }
}
