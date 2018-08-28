using System;
using UnityEngine;

[System.Serializable]
public class BodyShape : ShapeBase
{
    public enum DstBoneName : int
    {
        cf_J_ArmElbo_low_s_L,
        cf_J_ArmElbo_low_s_R,
        cf_J_ArmLow01_s_L,
        cf_J_ArmLow01_s_R,
        cf_J_ArmLow02_s_L,
        cf_J_ArmLow02_s_R,
        cf_J_ArmUp01_s_L,
        cf_J_ArmUp01_s_R,
        cf_J_ArmUp02_s_L,
        cf_J_ArmUp02_s_R,
        cf_J_ArmUp03_s_L,
        cf_J_ArmUp03_s_R,
        cf_J_Hand_s_L,
        cf_J_Hand_s_R,
        cf_J_Hand_Wrist_s_L,
        cf_J_Hand_Wrist_s_R,
        cf_J_Head_s,
        cf_J_Kosi01_s,
        cf_J_Kosi02_s,
        cf_J_LegKnee_back_s_L,
        cf_J_LegKnee_back_s_R,
        cf_J_LegKnee_low_s_L,
        cf_J_LegKnee_low_s_R,
        cf_J_LegLow01_s_L,
        cf_J_LegLow01_s_R,
        cf_J_LegLow02_s_L,
        cf_J_LegLow02_s_R,
        cf_J_LegLow03_s_L,
        cf_J_LegLow03_s_R,
        cf_J_LegUp01_s_L,
        cf_J_LegUp01_s_R,
        cf_J_LegUp02_s_L,
        cf_J_LegUp02_s_R,
        cf_J_LegUp03_s_L,
        cf_J_LegUp03_s_R,
        cf_J_LegUpDam_s_L,
        cf_J_LegUpDam_s_R,
        cf_J_Mune_Nip01_s_L,
        cf_J_Mune_Nip01_s_R,
        cf_J_Mune_Nip02_s_L,
        cf_J_Mune_Nip02_s_R,
        cf_J_Mune_Nipacs01_L,
        cf_J_Mune_Nipacs01_R,
        cf_J_Mune00_d_L,
        cf_J_Mune00_d_R,
        cf_J_Mune00_s_L,
        cf_J_Mune00_s_R,
        cf_J_Mune00_t_L,
        cf_J_Mune00_t_R,
        cf_J_Mune01_s_L,
        cf_J_Mune01_s_R,
        cf_J_Mune01_t_L,
        cf_J_Mune01_t_R,
        cf_J_Mune02_s_L,
        cf_J_Mune02_s_R,
        cf_J_Mune02_t_L,
        cf_J_Mune02_t_R,
        cf_J_Mune03_s_L,
        cf_J_Mune03_s_R,
        cf_J_Mune04_s_L,
        cf_J_Mune04_s_R,
        cf_J_Neck_s,
        cf_J_Shoulder02_s_L,
        cf_J_Shoulder02_s_R,
        cf_J_Siri_s_L,
        cf_J_Siri_s_R,
        cf_J_sk_siri_dam,
        cf_J_sk_top,
        cf_J_Spine01_s,
        cf_J_Spine02_s,
        cf_J_Spine03_s,
        cf_N_height,
        cf_J_sk_00_00_dam,
        cf_J_sk_01_00_dam,
        cf_J_sk_02_00_dam,
        cf_J_sk_03_00_dam,
        cf_J_sk_04_00_dam,
        cf_J_sk_05_00_dam,
        cf_J_sk_06_00_dam,
        cf_J_sk_07_00_dam,
        cf_hit_Mune02_s_L,
        cf_hit_Mune02_s_R,
        cf_hit_Kosi02_s,
        cf_hit_LegUp01_s_L,
        cf_hit_LegUp01_s_R,
        cf_hit_Siri_s_L,
        cf_hit_Siri_s_R
    }
    public enum SrcBoneName : int
    {
        cf_s_ArmElbo_low_s_L,
        cf_s_ArmElbo_low_s_R,
        cf_s_ArmElbo_up_s_L,
        cf_s_ArmElbo_up_s_R,
        cf_s_ArmLow01_h_L,
        cf_s_ArmLow01_h_R,
        cf_s_ArmLow01_s_L,
        cf_s_ArmLow01_s_R,
        cf_s_ArmLow02_h_L,
        cf_s_ArmLow02_h_R,
        cf_s_ArmLow02_s_L,
        cf_s_ArmLow02_s_R,
        cf_s_ArmUp01_h_L,
        cf_s_ArmUp01_h_R,
        cf_s_ArmUp01_s_L,
        cf_s_ArmUp01_s_R,
        cf_s_ArmUp01_s_tx_L,
        cf_s_ArmUp01_s_tx_R,
        cf_s_ArmUp02_h_L,
        cf_s_ArmUp02_h_R,
        cf_s_ArmUp02_s_L,
        cf_s_ArmUp02_s_R,
        cf_s_ArmUp03_h_L,
        cf_s_ArmUp03_h_R,
        cf_s_ArmUp03_s_L,
        cf_s_ArmUp03_s_R,
        cf_s_Hand_h_L,
        cf_s_Hand_h_R,
        cf_s_Hand_Wrist_h_L,
        cf_s_Hand_Wrist_h_R,
        cf_s_Hand_Wrist_s_L,
        cf_s_Hand_Wrist_s_R,
        cf_s_Head_h,
        cf_s_Head_s,
        cf_s_height,
        cf_s_Kosi01_h,
        cf_s_Kosi01_s,
        cf_s_Kosi01_s_sz,
        cf_s_Kosi02_h,
        cf_s_Kosi02_s,
        cf_s_Kosi02_s_sz,
        cf_s_LegKnee_back_s_L,
        cf_s_LegKnee_back_s_R,
        cf_s_LegKnee_h_L,
        cf_s_LegKnee_h_R,
        cf_s_LegKnee_low_s_L,
        cf_s_LegKnee_low_s_R,
        cf_s_LegKnee_up_s_L,
        cf_s_LegKnee_up_s_R,
        cf_s_LegLow01_h_L,
        cf_s_LegLow01_h_R,
        cf_s_LegLow01_s_L,
        cf_s_LegLow01_s_R,
        cf_s_LegLow02_h_L,
        cf_s_LegLow02_h_R,
        cf_s_LegLow02_s_L,
        cf_s_LegLow02_s_R,
        cf_s_LegLow03_s_L,
        cf_s_LegLow03_s_R,
        cf_s_LegUp01_blend_s_L,
        cf_s_LegUp01_blend_s_R,
        cf_s_LegUp01_blend_ss_L,
        cf_s_LegUp01_blend_ss_R,
        cf_s_LegUp01_h_L,
        cf_s_LegUp01_h_R,
        cf_s_LegUp01_s_L,
        cf_s_LegUp01_s_R,
        cf_s_LegUp02_blend_s_L,
        cf_s_LegUp02_blend_s_R,
        cf_s_LegUp02_h_L,
        cf_s_LegUp02_h_R,
        cf_s_LegUp02_s_L,
        cf_s_LegUp02_s_R,
        cf_s_LegUp03_blend_s_L,
        cf_s_LegUp03_blend_s_R,
        cf_s_LegUp03_h_L,
        cf_s_LegUp03_h_R,
        cf_s_LegUp03_s_L,
        cf_s_LegUp03_s_R,
        cf_s_LegUpDam_s_L,
        cf_s_LegUpDam_s_R,
        cf_s_Mune_Nip_dam_L,
        cf_s_Mune_Nip_dam_R,
        cf_s_Mune_Nip01_s_L,
        cf_s_Mune_Nip01_s_R,
        cf_s_Mune_Nip01_ss_L,
        cf_s_Mune_Nip01_ss_R,
        cf_s_Mune_Nip02_s_L,
        cf_s_Mune_Nip02_s_R,
        cf_s_Mune_Nipacs01_L,
        cf_s_Mune_Nipacs01_R,
        cf_s_Mune_Nipacs02_L,
        cf_s_Mune_Nipacs02_R,
        cf_s_Mune00_h_L,
        cf_s_Mune00_h_R,
        cf_s_Mune00_s_L,
        cf_s_Mune00_s_R,
        cf_s_Mune00_ss_02_L,
        cf_s_Mune00_ss_02_R,
        cf_s_Mune00_ss_02sz_L,
        cf_s_Mune00_ss_02sz_R,
        cf_s_Mune00_ss_03_L,
        cf_s_Mune00_ss_03_R,
        cf_s_Mune00_ss_03sz_L,
        cf_s_Mune00_ss_03sz_R,
        cf_s_Mune00_ss_ty_L,
        cf_s_Mune00_ss_ty_R,
        cf_s_Mune01_s_L,
        cf_s_Mune01_s_R,
        cf_s_Mune01_s_rx_L,
        cf_s_Mune01_s_rx_R,
        cf_s_Mune01_s_ry_L,
        cf_s_Mune01_s_ry_R,
        cf_s_Mune01_s_tx_L,
        cf_s_Mune01_s_tx_R,
        cf_s_Mune01_s_tz_L,
        cf_s_Mune01_s_tz_R,
        cf_s_Mune02_s_L,
        cf_s_Mune02_s_R,
        cf_s_Mune02_s_rx_L,
        cf_s_Mune02_s_rx_R,
        cf_s_Mune02_s_tz_L,
        cf_s_Mune02_s_tz_R,
        cf_s_Mune03_s_L,
        cf_s_Mune03_s_R,
        cf_s_Mune03_s_rx_L,
        cf_s_Mune03_s_rx_R,
        cf_s_Mune04_s_L,
        cf_s_Mune04_s_R,
        cf_s_Neck_h,
        cf_s_Neck_s,
        cf_s_Neck_s_sz,
        cf_s_Shoulder_h_L,
        cf_s_Shoulder_h_R,
        cf_s_Shoulder02_h_L,
        cf_s_Shoulder02_h_R,
        cf_s_Shoulder02_s_L,
        cf_s_Shoulder02_s_R,
        cf_s_Shoulder02_s_tx_L,
        cf_s_Shoulder02_s_tx_R,
        cf_s_Siri_kosi01_s_L,
        cf_s_Siri_kosi01_s_R,
        cf_s_Siri_kosi02_s_L,
        cf_s_Siri_kosi02_s_R,
        cf_s_Siri_legup01_s_L,
        cf_s_Siri_legup01_s_R,
        cf_s_Siri_s_L,
        cf_s_Siri_s_R,
        cf_s_Siri_s_ty_L,
        cf_s_Siri_s_ty_R,
        cf_s_sk_siri_dam,
        cf_s_sk_siri_ty_dam,
        cf_s_sk_top_h,
        cf_s_Spine01_h,
        cf_s_Spine01_s,
        cf_s_Spine01_s_sz,
        cf_s_Spine01_s_ty,
        cf_s_Spine02_h,
        cf_s_Spine02_s,
        cf_s_Spine02_s_sz,
        cf_s_Spine03_h,
        cf_s_Spine03_s,
        cf_s_Spine03_s_sz,
        cf_s_sk_00_sx01,
        cf_s_sk_00_sx02,
        cf_s_sk_00_sz01,
        cf_s_sk_00_sz02,
        cf_s_sk_01_sx01,
        cf_s_sk_01_sx02,
        cf_s_sk_01_sz01,
        cf_s_sk_01_sz02,
        cf_s_sk_02_sx01,
        cf_s_sk_02_sx02,
        cf_s_sk_02_sz01,
        cf_s_sk_02_sz02,
        cf_s_sk_03_sx01,
        cf_s_sk_03_sx02,
        cf_s_sk_03_sz01,
        cf_s_sk_03_sz02,
        cf_s_sk_04_sx01,
        cf_s_sk_04_sx02,
        cf_s_sk_04_sz01,
        cf_s_sk_04_sz02,
        cf_s_sk_05_sx01,
        cf_s_sk_05_sx02,
        cf_s_sk_05_sz01,
        cf_s_sk_05_sz02,
        cf_s_sk_06_sx01,
        cf_s_sk_06_sx02,
        cf_s_sk_06_sz01,
        cf_s_sk_06_sz02,
        cf_s_sk_07_sx01,
        cf_s_sk_07_sx02,
        cf_s_sk_07_sz01,
        cf_s_sk_07_sz02,
        cf_hit_Kosi02_Kosi01sx_a,
        cf_hit_Kosi02_Kosi01sz_a,
        cf_hit_Kosi02_Kosi02sx_a,
        cf_hit_Kosi02_Kosi02sz_a,
        cf_hit_LegUp01_Kosi02sz_a,
        cf_hit_LegUp01_Kosi02sx_a,
        cf_hit_Siri_Kosi02sz_a,
        cf_hit_Siri_Kosi02sx_a,
        cf_hit_Siri_size_a,
        cf_hit_Siri_rot_a,
        cf_hit_Mune_size_a,
        cf_hit_Siri_LegUp01,
        cf_hit_height
    }

    public enum UpdateMask
    {
        UPDATE_MASK_BUST_L = 1,
        UPDATE_MASK_BUST_R = 2,
        UPDATE_MASK_BUST = 3,
        UPDATE_MASK_NIP_L = 4,
        UPDATE_MASK_NIP_R = 8,
        UPDATE_MASK_NIP = 12,
        UPDATE_MASK_ETC = 16,
        UPDATE_MASK_ALL = 31,
    }

    [SerializeField]
    public UpdateMask updateMask = UpdateMask.UPDATE_MASK_ALL;

    public BodyShape(GameObject go)
        : base(go, "cf_custombody", "cf_anmShapeBody", "cf_controlbody")
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
        float num = this.boneID2SrcPose[195].pos.y + this.boneID2SrcPose[196].pos.y;
        float num2 = this.boneID2SrcPose[195].scale.y * this.boneID2SrcPose[196].scale.y;
        float x = this.boneID2SrcPose[196].scale.x;
        float z = this.boneID2SrcPose[196].pos.z;
        float num3 = this.boneID2SrcPose[197].pos.y + this.boneID2SrcPose[198].pos.y;
        float num4 = this.boneID2SrcPose[197].pos.z + this.boneID2SrcPose[198].pos.z;
        float num5 = this.boneID2SrcPose[197].scale.y * this.boneID2SrcPose[198].scale.y;
        float num6 = this.boneID2SrcPose[197].scale.x * this.boneID2SrcPose[198].scale.x;
        float num7 = this.boneID2SrcPose[199].pos.x + this.boneID2SrcPose[200].pos.x;
        float num8 = this.boneID2SrcPose[199].rot.z + this.boneID2SrcPose[200].rot.z;
        float x2 = this.boneID2SrcPose[199].scale.x * this.boneID2SrcPose[200].scale.x;
        float y = this.boneID2SrcPose[199].scale.y * this.boneID2SrcPose[200].scale.y;
        float num9 = this.boneID2SrcPose[201].scale.x * this.boneID2SrcPose[202].scale.x;
        float num10 = this.boneID2SrcPose[201].scale.y * this.boneID2SrcPose[202].scale.y;
        float x3 = this.boneID2SrcPose[202].pos.x;
        float num11 = this.boneID2SrcPose[201].pos.z + this.boneID2SrcPose[202].pos.z;
        float x4 = this.boneID2SrcPose[203].pos.x;
        float y2 = this.boneID2SrcPose[203].pos.y;
        float z2 = this.boneID2SrcPose[203].pos.z;
        float x5 = this.boneID2SrcPose[203].scale.x;
        float y3 = this.boneID2SrcPose[203].scale.y;
        float x6 = this.boneID2SrcPose[204].pos.x;
        float y4 = this.boneID2SrcPose[204].pos.y;
        float z3 = this.boneID2SrcPose[204].pos.z;
        float x7 = this.boneID2SrcPose[204].scale.x;
        float x8 = this.boneID2SrcPose[204].rot.x;
        float z4 = this.boneID2SrcPose[206].pos.z;
        float x9 = this.boneID2SrcPose[206].scale.x;
        if ((this.updateMask & UpdateMask.UPDATE_MASK_ETC) != 0)
        {
            this.boneID2DstPose[71].trfBone.SetLocalScale(this.boneID2SrcPose[34].scale.x, this.boneID2SrcPose[34].scale.y, this.boneID2SrcPose[34].scale.z);
            this.boneID2DstPose[67].trfBone.SetLocalScale(this.boneID2SrcPose[152].scale.x, 1f, this.boneID2SrcPose[152].scale.z);
            this.boneID2DstPose[72].trfBone.SetLocalPositionZ(this.boneID2SrcPose[163].pos.z + this.boneID2SrcPose[164].pos.z + this.boneID2SrcPose[165].pos.z + this.boneID2SrcPose[166].pos.z);
            this.boneID2DstPose[72].trfBone.SetLocalRotation(this.boneID2SrcPose[163].rot.x + this.boneID2SrcPose[165].rot.x + this.boneID2SrcPose[166].rot.x, this.boneID2SrcPose[163].rot.y, 0f);
            this.boneID2DstPose[73].trfBone.SetLocalPositionX(this.boneID2SrcPose[167].pos.x);
            this.boneID2DstPose[73].trfBone.SetLocalPositionZ(this.boneID2SrcPose[167].pos.z + this.boneID2SrcPose[168].pos.z + this.boneID2SrcPose[169].pos.z + this.boneID2SrcPose[170].pos.z);
            this.boneID2DstPose[73].trfBone.SetLocalRotation(this.boneID2SrcPose[167].rot.x + this.boneID2SrcPose[168].rot.x + this.boneID2SrcPose[169].rot.x + this.boneID2SrcPose[170].rot.x, this.boneID2SrcPose[167].rot.y, 0f);
            this.boneID2DstPose[74].trfBone.SetLocalPositionX(this.boneID2SrcPose[171].pos.x + this.boneID2SrcPose[172].pos.x);
            this.boneID2DstPose[74].trfBone.SetLocalPositionZ(this.boneID2SrcPose[171].pos.z + this.boneID2SrcPose[172].pos.z + this.boneID2SrcPose[173].pos.z + this.boneID2SrcPose[174].pos.z);
            this.boneID2DstPose[74].trfBone.SetLocalRotation(this.boneID2SrcPose[171].rot.x + this.boneID2SrcPose[172].rot.x, this.boneID2SrcPose[171].rot.y, 0f);
            this.boneID2DstPose[75].trfBone.SetLocalPositionX(this.boneID2SrcPose[175].pos.x);
            this.boneID2DstPose[75].trfBone.SetLocalPositionZ(this.boneID2SrcPose[175].pos.z + this.boneID2SrcPose[176].pos.z + this.boneID2SrcPose[177].pos.z + this.boneID2SrcPose[178].pos.z);
            this.boneID2DstPose[75].trfBone.SetLocalRotation(this.boneID2SrcPose[175].rot.x + this.boneID2SrcPose[176].rot.x + this.boneID2SrcPose[177].rot.x + this.boneID2SrcPose[178].rot.x, this.boneID2SrcPose[175].rot.y, 0f);
            this.boneID2DstPose[76].trfBone.SetLocalPositionZ(this.boneID2SrcPose[179].pos.z + this.boneID2SrcPose[180].pos.z + this.boneID2SrcPose[181].pos.z + this.boneID2SrcPose[182].pos.z);
            this.boneID2DstPose[76].trfBone.SetLocalRotation(this.boneID2SrcPose[179].rot.x + this.boneID2SrcPose[181].rot.x + this.boneID2SrcPose[182].rot.x, this.boneID2SrcPose[179].rot.y, 0f);
            this.boneID2DstPose[77].trfBone.SetLocalPositionX(this.boneID2SrcPose[183].pos.x + this.boneID2SrcPose[184].pos.x);
            this.boneID2DstPose[77].trfBone.SetLocalPositionZ(this.boneID2SrcPose[183].pos.z + this.boneID2SrcPose[184].pos.z + this.boneID2SrcPose[185].pos.z + this.boneID2SrcPose[186].pos.z);
            this.boneID2DstPose[77].trfBone.SetLocalRotation(this.boneID2SrcPose[183].rot.x + this.boneID2SrcPose[184].rot.x + this.boneID2SrcPose[185].rot.x + this.boneID2SrcPose[186].rot.x, this.boneID2SrcPose[183].rot.y, 0f);
            this.boneID2DstPose[78].trfBone.SetLocalPositionX(this.boneID2SrcPose[187].pos.x + this.boneID2SrcPose[188].pos.x);
            this.boneID2DstPose[78].trfBone.SetLocalPositionZ(this.boneID2SrcPose[187].pos.z + this.boneID2SrcPose[188].pos.z + this.boneID2SrcPose[189].pos.z + this.boneID2SrcPose[190].pos.z);
            this.boneID2DstPose[78].trfBone.SetLocalRotation(this.boneID2SrcPose[187].rot.x + this.boneID2SrcPose[188].rot.x, this.boneID2SrcPose[187].rot.y, 0f);
            this.boneID2DstPose[79].trfBone.SetLocalPositionX(this.boneID2SrcPose[191].pos.x + this.boneID2SrcPose[192].pos.x);
            this.boneID2DstPose[79].trfBone.SetLocalPositionZ(this.boneID2SrcPose[191].pos.z + this.boneID2SrcPose[192].pos.z + this.boneID2SrcPose[193].pos.z + this.boneID2SrcPose[194].pos.z);
            this.boneID2DstPose[79].trfBone.SetLocalRotation(this.boneID2SrcPose[191].rot.x + this.boneID2SrcPose[192].rot.x + this.boneID2SrcPose[193].rot.x + this.boneID2SrcPose[194].rot.x, this.boneID2SrcPose[191].rot.y, 0f);
            this.boneID2DstPose[66].trfBone.SetLocalPositionZ(this.boneID2SrcPose[151].pos.z + this.boneID2SrcPose[150].pos.z);
            this.boneID2DstPose[66].trfBone.SetLocalRotation(this.boneID2SrcPose[151].rot.x, 0f, 0f);
            this.boneID2DstPose[62].trfBone.SetLocalPositionX(this.boneID2SrcPose[138].pos.x);
            this.boneID2DstPose[62].trfBone.SetLocalScale(this.boneID2SrcPose[134].scale.x, this.boneID2SrcPose[136].scale.y * this.boneID2SrcPose[134].scale.z, this.boneID2SrcPose[136].scale.z * this.boneID2SrcPose[134].scale.y);
            this.boneID2DstPose[63].trfBone.SetLocalPositionX(this.boneID2SrcPose[139].pos.x);
            this.boneID2DstPose[63].trfBone.SetLocalScale(this.boneID2SrcPose[135].scale.x, this.boneID2SrcPose[137].scale.y * this.boneID2SrcPose[135].scale.z, this.boneID2SrcPose[137].scale.z * this.boneID2SrcPose[135].scale.y);
            this.boneID2DstPose[6].trfBone.SetLocalPositionX(this.boneID2SrcPose[16].pos.x);
            this.boneID2DstPose[6].trfBone.SetLocalPositionY(this.boneID2SrcPose[14].pos.y + this.boneID2SrcPose[16].pos.y);
            this.boneID2DstPose[6].trfBone.SetLocalRotation(0f, this.boneID2SrcPose[14].rot.y, this.boneID2SrcPose[14].rot.z + this.boneID2SrcPose[16].rot.z);
            this.boneID2DstPose[6].trfBone.SetLocalScale(1f, this.boneID2SrcPose[14].scale.y * this.boneID2SrcPose[12].scale.y, this.boneID2SrcPose[14].scale.z * this.boneID2SrcPose[12].scale.z);
            this.boneID2DstPose[7].trfBone.SetLocalPositionX(this.boneID2SrcPose[17].pos.x);
            this.boneID2DstPose[7].trfBone.SetLocalPositionY(this.boneID2SrcPose[15].pos.y + this.boneID2SrcPose[17].pos.y);
            this.boneID2DstPose[7].trfBone.SetLocalRotation(0f, this.boneID2SrcPose[15].rot.y, this.boneID2SrcPose[15].rot.z + this.boneID2SrcPose[17].rot.z);
            this.boneID2DstPose[7].trfBone.SetLocalScale(1f, this.boneID2SrcPose[15].scale.y * this.boneID2SrcPose[13].scale.y, this.boneID2SrcPose[15].scale.z * this.boneID2SrcPose[13].scale.z);
            this.boneID2DstPose[8].trfBone.SetLocalScale(1f, this.boneID2SrcPose[20].scale.y * this.boneID2SrcPose[18].scale.y, this.boneID2SrcPose[20].scale.z * this.boneID2SrcPose[18].scale.z);
            this.boneID2DstPose[9].trfBone.SetLocalScale(1f, this.boneID2SrcPose[21].scale.y * this.boneID2SrcPose[19].scale.y, this.boneID2SrcPose[21].scale.z * this.boneID2SrcPose[19].scale.z);
            this.boneID2DstPose[10].trfBone.SetLocalScale(1f, this.boneID2SrcPose[24].scale.y * this.boneID2SrcPose[22].scale.y, this.boneID2SrcPose[24].scale.z * this.boneID2SrcPose[22].scale.z);
            this.boneID2DstPose[11].trfBone.SetLocalScale(1f, this.boneID2SrcPose[25].scale.y * this.boneID2SrcPose[23].scale.y, this.boneID2SrcPose[25].scale.z * this.boneID2SrcPose[23].scale.z);
            this.boneID2DstPose[0].trfBone.SetLocalScale(1f, this.boneID2SrcPose[2].scale.y * this.boneID2SrcPose[0].scale.y, this.boneID2SrcPose[2].scale.z * this.boneID2SrcPose[0].scale.z);
            this.boneID2DstPose[1].trfBone.SetLocalScale(1f, this.boneID2SrcPose[3].scale.y * this.boneID2SrcPose[1].scale.y, this.boneID2SrcPose[3].scale.z * this.boneID2SrcPose[1].scale.z);
            this.boneID2DstPose[2].trfBone.SetLocalScale(1f, this.boneID2SrcPose[6].scale.y * this.boneID2SrcPose[4].scale.y, this.boneID2SrcPose[6].scale.z * this.boneID2SrcPose[4].scale.z);
            this.boneID2DstPose[3].trfBone.SetLocalScale(1f, this.boneID2SrcPose[7].scale.y * this.boneID2SrcPose[5].scale.y, this.boneID2SrcPose[7].scale.z * this.boneID2SrcPose[5].scale.z);
            this.boneID2DstPose[4].trfBone.SetLocalScale(1f, this.boneID2SrcPose[10].scale.y * this.boneID2SrcPose[8].scale.y, this.boneID2SrcPose[10].scale.z * this.boneID2SrcPose[8].scale.z);
            this.boneID2DstPose[5].trfBone.SetLocalScale(1f, this.boneID2SrcPose[11].scale.y * this.boneID2SrcPose[9].scale.y, this.boneID2SrcPose[11].scale.z * this.boneID2SrcPose[9].scale.z);
            this.boneID2DstPose[12].trfBone.SetLocalScale(this.boneID2SrcPose[26].scale.x, this.boneID2SrcPose[26].scale.y, this.boneID2SrcPose[26].scale.z);
            this.boneID2DstPose[13].trfBone.SetLocalScale(this.boneID2SrcPose[27].scale.x, this.boneID2SrcPose[27].scale.y, this.boneID2SrcPose[27].scale.z);
            this.boneID2DstPose[14].trfBone.SetLocalScale(1f, this.boneID2SrcPose[30].scale.y * this.boneID2SrcPose[28].scale.y, this.boneID2SrcPose[30].scale.z * this.boneID2SrcPose[28].scale.z);
            this.boneID2DstPose[15].trfBone.SetLocalScale(1f, this.boneID2SrcPose[31].scale.y * this.boneID2SrcPose[29].scale.y, this.boneID2SrcPose[31].scale.z * this.boneID2SrcPose[29].scale.z);
            this.boneID2DstPose[17].trfBone.SetLocalScale(this.boneID2SrcPose[35].scale.x * this.boneID2SrcPose[36].scale.x, 1f, this.boneID2SrcPose[35].scale.z * this.boneID2SrcPose[37].scale.z);
            this.boneID2DstPose[18].trfBone.SetLocalScale(this.boneID2SrcPose[38].scale.x * this.boneID2SrcPose[39].scale.x, 1f, this.boneID2SrcPose[38].scale.z * this.boneID2SrcPose[40].scale.z);
            this.boneID2DstPose[68].trfBone.SetLocalScale(this.boneID2SrcPose[153].scale.x * this.boneID2SrcPose[154].scale.x, 1f, this.boneID2SrcPose[153].scale.z * this.boneID2SrcPose[155].scale.z);
            this.boneID2DstPose[68].trfBone.SetLocalPositionY(this.boneID2SrcPose[156].pos.y);
            this.boneID2DstPose[68].trfBone.SetLocalPositionZ(this.boneID2SrcPose[154].pos.z + this.boneID2SrcPose[155].pos.z);
            this.boneID2DstPose[69].trfBone.SetLocalScale(this.boneID2SrcPose[157].scale.x * this.boneID2SrcPose[158].scale.x, 1f, this.boneID2SrcPose[157].scale.z * this.boneID2SrcPose[159].scale.z);
            this.boneID2DstPose[70].trfBone.SetLocalScale(this.boneID2SrcPose[160].scale.x * this.boneID2SrcPose[161].scale.x, 1f, this.boneID2SrcPose[160].scale.z * this.boneID2SrcPose[162].scale.z);
            this.boneID2DstPose[61].trfBone.SetLocalScale(this.boneID2SrcPose[129].scale.x * this.boneID2SrcPose[130].scale.x, 1f, this.boneID2SrcPose[129].scale.z * this.boneID2SrcPose[131].scale.z);
            this.boneID2DstPose[16].trfBone.SetLocalScale(this.boneID2SrcPose[32].scale.x * this.boneID2SrcPose[33].scale.x, this.boneID2SrcPose[32].scale.y * this.boneID2SrcPose[33].scale.y, this.boneID2SrcPose[32].scale.z * this.boneID2SrcPose[33].scale.z);
        }
        if ((this.updateMask & UpdateMask.UPDATE_MASK_BUST_L) != 0)
        {
            float x10 = this.boneID2SrcPose[205].pos.x;
            float y5 = this.boneID2SrcPose[205].pos.y;
            float z5 = this.boneID2SrcPose[205].pos.z;
            float x11 = this.boneID2SrcPose[205].scale.x;
            this.boneID2DstPose[47].trfBone.SetLocalPositionX(this.boneID2SrcPose[97].pos.x + this.boneID2SrcPose[101].pos.x);
            this.boneID2DstPose[47].trfBone.SetLocalPositionY(this.boneID2SrcPose[99].pos.y + this.boneID2SrcPose[105].pos.y);
            this.boneID2DstPose[47].trfBone.SetLocalPositionZ(this.boneID2SrcPose[99].pos.z + this.boneID2SrcPose[103].pos.z);
            this.boneID2DstPose[47].trfBone.SetLocalRotation(this.boneID2SrcPose[99].rot.x + this.boneID2SrcPose[103].rot.x + this.boneID2SrcPose[105].rot.x, this.boneID2SrcPose[101].rot.y + this.boneID2SrcPose[105].rot.y, 0f);
            this.boneID2DstPose[47].trfBone.SetLocalScale(this.boneID2SrcPose[93].scale.x, this.boneID2SrcPose[93].scale.y, this.boneID2SrcPose[93].scale.z);
            this.boneID2DstPose[45].trfBone.SetLocalPositionY(this.boneID2SrcPose[95].pos.y);
            this.boneID2DstPose[45].trfBone.SetLocalPositionZ(this.boneID2SrcPose[95].pos.z);
            this.boneID2DstPose[45].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[95].rot.z);
            this.boneID2DstPose[45].trfBone.SetLocalScale(this.boneID2SrcPose[95].scale.x, this.boneID2SrcPose[95].scale.y, this.boneID2SrcPose[95].scale.z);
            this.boneID2DstPose[43].trfBone.SetLocalPositionX(this.boneID2SrcPose[113].pos.x + this.boneID2SrcPose[111].pos.x);
            this.boneID2DstPose[43].trfBone.SetLocalPositionZ(0.072f + this.boneID2SrcPose[109].pos.z + this.boneID2SrcPose[111].pos.z);
            this.boneID2DstPose[43].trfBone.SetLocalRotation(this.boneID2SrcPose[109].rot.x, this.boneID2SrcPose[111].rot.y, 0f);
            this.boneID2DstPose[49].trfBone.SetLocalPositionY(this.boneID2SrcPose[107].pos.y);
            this.boneID2DstPose[49].trfBone.SetLocalRotation(this.boneID2SrcPose[107].rot.x, this.boneID2SrcPose[107].rot.y, this.boneID2SrcPose[107].rot.z);
            this.boneID2DstPose[49].trfBone.SetLocalScale(this.boneID2SrcPose[107].scale.x, this.boneID2SrcPose[107].scale.y, this.boneID2SrcPose[107].scale.z);
            this.boneID2DstPose[51].trfBone.SetLocalPositionX(this.boneID2SrcPose[107].pos.x);
            this.boneID2DstPose[51].trfBone.SetLocalPositionZ(0.03f + this.boneID2SrcPose[115].pos.z);
            this.boneID2DstPose[51].trfBone.SetLocalRotation(this.boneID2SrcPose[119].rot.x, 0f, 0f);
            this.boneID2DstPose[53].trfBone.SetLocalPositionY(this.boneID2SrcPose[117].pos.y);
            this.boneID2DstPose[53].trfBone.SetLocalPositionZ(this.boneID2SrcPose[117].pos.z);
            this.boneID2DstPose[53].trfBone.SetLocalRotation(this.boneID2SrcPose[117].rot.x, 0f, 0f);
            this.boneID2DstPose[53].trfBone.SetLocalScale(this.boneID2SrcPose[117].scale.x, this.boneID2SrcPose[117].scale.y, this.boneID2SrcPose[117].scale.z);
            this.boneID2DstPose[55].trfBone.SetLocalPositionZ(0.03f + this.boneID2SrcPose[121].pos.z);
            this.boneID2DstPose[55].trfBone.SetLocalRotation(this.boneID2SrcPose[125].rot.x, 0f, 0f);
            this.boneID2DstPose[57].trfBone.SetLocalPositionZ(this.boneID2SrcPose[123].pos.z);
            this.boneID2DstPose[57].trfBone.SetLocalScale(this.boneID2SrcPose[123].scale.x, this.boneID2SrcPose[123].scale.y, this.boneID2SrcPose[123].scale.z);
            this.boneID2DstPose[59].trfBone.SetLocalPositionZ(this.boneID2SrcPose[127].pos.z);
            this.boneID2DstPose[59].trfBone.SetLocalScale(this.boneID2SrcPose[127].scale.x, this.boneID2SrcPose[127].scale.y, this.boneID2SrcPose[127].scale.z);
            this.boneID2DstPose[37].trfBone.SetLocalPositionZ(this.boneID2SrcPose[85].pos.z + this.boneID2SrcPose[83].pos.z);
            this.boneID2DstPose[37].trfBone.SetLocalScale(this.boneID2SrcPose[85].scale.x * this.boneID2SrcPose[83].scale.x, this.boneID2SrcPose[85].scale.y * this.boneID2SrcPose[83].scale.y, this.boneID2SrcPose[85].scale.z);
            this.boneID2DstPose[80].trfBone.SetLocalPositionX(x10);
            this.boneID2DstPose[80].trfBone.SetLocalPositionY(y5);
            this.boneID2DstPose[80].trfBone.SetLocalPositionZ(z5);
            this.boneID2DstPose[80].trfBone.SetLocalScale(x11, 1f, x11);
        }
        if ((this.updateMask & UpdateMask.UPDATE_MASK_NIP_L) != 0)
        {
            this.boneID2DstPose[39].trfBone.SetLocalPositionZ(this.boneID2SrcPose[87].pos.z);
            this.boneID2DstPose[39].trfBone.SetLocalScale(this.boneID2SrcPose[87].scale.x, this.boneID2SrcPose[87].scale.y, this.boneID2SrcPose[87].scale.z);
            this.boneID2DstPose[41].trfBone.SetLocalPositionZ(this.boneID2SrcPose[89].pos.z + this.boneID2SrcPose[91].pos.z);
            this.boneID2DstPose[41].trfBone.SetLocalScale(this.boneID2SrcPose[81].scale.x * this.boneID2SrcPose[91].scale.x, this.boneID2SrcPose[81].scale.y * this.boneID2SrcPose[91].scale.y, this.boneID2SrcPose[81].scale.z * this.boneID2SrcPose[91].scale.z);
        }
        if ((this.updateMask & UpdateMask.UPDATE_MASK_BUST_R) != 0)
        {
            float x12 = this.boneID2SrcPose[205].pos.x;
            float y6 = this.boneID2SrcPose[205].pos.y;
            float z6 = this.boneID2SrcPose[205].pos.z;
            float x13 = this.boneID2SrcPose[205].scale.x;
            this.boneID2DstPose[48].trfBone.SetLocalPositionX(this.boneID2SrcPose[98].pos.x + this.boneID2SrcPose[102].pos.x);
            this.boneID2DstPose[48].trfBone.SetLocalPositionY(this.boneID2SrcPose[100].pos.y + this.boneID2SrcPose[106].pos.y);
            this.boneID2DstPose[48].trfBone.SetLocalPositionZ(this.boneID2SrcPose[100].pos.z + this.boneID2SrcPose[104].pos.z);
            this.boneID2DstPose[48].trfBone.SetLocalRotation(this.boneID2SrcPose[100].rot.x + this.boneID2SrcPose[104].rot.x + this.boneID2SrcPose[106].rot.x, this.boneID2SrcPose[102].rot.y + this.boneID2SrcPose[106].rot.y, 0f);
            this.boneID2DstPose[48].trfBone.SetLocalScale(this.boneID2SrcPose[94].scale.x, this.boneID2SrcPose[94].scale.y, this.boneID2SrcPose[94].scale.z);
            this.boneID2DstPose[46].trfBone.SetLocalPositionY(this.boneID2SrcPose[96].pos.y);
            this.boneID2DstPose[46].trfBone.SetLocalPositionZ(this.boneID2SrcPose[96].pos.z);
            this.boneID2DstPose[46].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[96].rot.z);
            this.boneID2DstPose[46].trfBone.SetLocalScale(this.boneID2SrcPose[96].scale.x, this.boneID2SrcPose[96].scale.y, this.boneID2SrcPose[96].scale.z);
            this.boneID2DstPose[44].trfBone.SetLocalPositionX(this.boneID2SrcPose[114].pos.x + this.boneID2SrcPose[112].pos.x);
            this.boneID2DstPose[44].trfBone.SetLocalPositionZ(0.072f + this.boneID2SrcPose[110].pos.z + this.boneID2SrcPose[112].pos.z);
            this.boneID2DstPose[44].trfBone.SetLocalRotation(this.boneID2SrcPose[110].rot.x, this.boneID2SrcPose[112].rot.y, 0f);
            this.boneID2DstPose[50].trfBone.SetLocalPositionY(this.boneID2SrcPose[108].pos.y);
            this.boneID2DstPose[50].trfBone.SetLocalRotation(this.boneID2SrcPose[108].rot.x, this.boneID2SrcPose[108].rot.y, this.boneID2SrcPose[108].rot.z);
            this.boneID2DstPose[50].trfBone.SetLocalScale(this.boneID2SrcPose[108].scale.x, this.boneID2SrcPose[108].scale.y, this.boneID2SrcPose[108].scale.z);
            this.boneID2DstPose[52].trfBone.SetLocalPositionX(this.boneID2SrcPose[108].pos.x);
            this.boneID2DstPose[52].trfBone.SetLocalPositionZ(0.03f + this.boneID2SrcPose[116].pos.z);
            this.boneID2DstPose[52].trfBone.SetLocalRotation(this.boneID2SrcPose[120].rot.x, 0f, 0f);
            this.boneID2DstPose[54].trfBone.SetLocalPositionY(this.boneID2SrcPose[118].pos.y);
            this.boneID2DstPose[54].trfBone.SetLocalPositionZ(this.boneID2SrcPose[118].pos.z);
            this.boneID2DstPose[54].trfBone.SetLocalRotation(this.boneID2SrcPose[118].rot.x, 0f, 0f);
            this.boneID2DstPose[54].trfBone.SetLocalScale(this.boneID2SrcPose[118].scale.x, this.boneID2SrcPose[118].scale.y, this.boneID2SrcPose[118].scale.z);
            this.boneID2DstPose[56].trfBone.SetLocalPositionZ(0.03f + this.boneID2SrcPose[122].pos.z);
            this.boneID2DstPose[56].trfBone.SetLocalRotation(this.boneID2SrcPose[126].rot.x, 0f, 0f);
            this.boneID2DstPose[58].trfBone.SetLocalPositionZ(this.boneID2SrcPose[124].pos.z);
            this.boneID2DstPose[58].trfBone.SetLocalScale(this.boneID2SrcPose[124].scale.x, this.boneID2SrcPose[124].scale.y, this.boneID2SrcPose[124].scale.z);
            this.boneID2DstPose[60].trfBone.SetLocalPositionZ(this.boneID2SrcPose[128].pos.z);
            this.boneID2DstPose[60].trfBone.SetLocalScale(this.boneID2SrcPose[128].scale.x, this.boneID2SrcPose[128].scale.y, this.boneID2SrcPose[128].scale.z);
            this.boneID2DstPose[38].trfBone.SetLocalPositionZ(this.boneID2SrcPose[86].pos.z + this.boneID2SrcPose[84].pos.z);
            this.boneID2DstPose[38].trfBone.SetLocalScale(this.boneID2SrcPose[86].scale.x * this.boneID2SrcPose[84].scale.x, this.boneID2SrcPose[86].scale.y * this.boneID2SrcPose[84].scale.y, this.boneID2SrcPose[86].scale.z);
            this.boneID2DstPose[81].trfBone.SetLocalPositionX(x12);
            this.boneID2DstPose[81].trfBone.SetLocalPositionY(y6);
            this.boneID2DstPose[81].trfBone.SetLocalPositionZ(z6);
            this.boneID2DstPose[81].trfBone.SetLocalScale(x13, 1f, x13);
        }
        if ((this.updateMask & UpdateMask.UPDATE_MASK_NIP_R) != 0)
        {
            this.boneID2DstPose[40].trfBone.SetLocalPositionZ(this.boneID2SrcPose[88].pos.z);
            this.boneID2DstPose[40].trfBone.SetLocalScale(this.boneID2SrcPose[88].scale.x, this.boneID2SrcPose[88].scale.y, this.boneID2SrcPose[88].scale.z);
            this.boneID2DstPose[42].trfBone.SetLocalPositionZ(this.boneID2SrcPose[90].pos.z + this.boneID2SrcPose[92].pos.z);
            this.boneID2DstPose[42].trfBone.SetLocalScale(this.boneID2SrcPose[82].scale.x * this.boneID2SrcPose[92].scale.x, this.boneID2SrcPose[82].scale.y * this.boneID2SrcPose[92].scale.y, this.boneID2SrcPose[82].scale.z * this.boneID2SrcPose[92].scale.z);
        }
        if ((this.updateMask & UpdateMask.UPDATE_MASK_ETC) != 0)
        {
            this.boneID2DstPose[35].trfBone.SetLocalScale(this.boneID2SrcPose[79].scale.x, 1f, this.boneID2SrcPose[79].scale.z);
            this.boneID2DstPose[36].trfBone.SetLocalScale(this.boneID2SrcPose[80].scale.x, 1f, this.boneID2SrcPose[80].scale.z);
            this.boneID2DstPose[29].trfBone.SetLocalPositionX(this.boneID2SrcPose[65].pos.x + this.boneID2SrcPose[59].pos.x);
            this.boneID2DstPose[29].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[59].rot.z);
            this.boneID2DstPose[29].trfBone.SetLocalScale(this.boneID2SrcPose[63].scale.x * this.boneID2SrcPose[65].scale.x * this.boneID2SrcPose[59].scale.x, 1f, this.boneID2SrcPose[63].scale.z * this.boneID2SrcPose[65].scale.z * this.boneID2SrcPose[61].scale.z);
            this.boneID2DstPose[30].trfBone.SetLocalPositionX(this.boneID2SrcPose[66].pos.x + this.boneID2SrcPose[60].pos.x);
            this.boneID2DstPose[30].trfBone.SetLocalRotation(0f, 0f, this.boneID2SrcPose[60].rot.z);
            this.boneID2DstPose[30].trfBone.SetLocalScale(this.boneID2SrcPose[64].scale.x * this.boneID2SrcPose[66].scale.x * this.boneID2SrcPose[60].scale.x, 1f, this.boneID2SrcPose[64].scale.z * this.boneID2SrcPose[66].scale.z * this.boneID2SrcPose[62].scale.z);
            this.boneID2DstPose[31].trfBone.SetLocalScale(this.boneID2SrcPose[69].scale.x * this.boneID2SrcPose[71].scale.x * this.boneID2SrcPose[67].scale.x, 1f, this.boneID2SrcPose[69].scale.z * this.boneID2SrcPose[71].scale.z * this.boneID2SrcPose[67].scale.z);
            this.boneID2DstPose[32].trfBone.SetLocalScale(this.boneID2SrcPose[70].scale.x * this.boneID2SrcPose[72].scale.x * this.boneID2SrcPose[68].scale.x, 1f, this.boneID2SrcPose[70].scale.z * this.boneID2SrcPose[72].scale.z * this.boneID2SrcPose[68].scale.z);
            this.boneID2DstPose[33].trfBone.SetLocalScale(this.boneID2SrcPose[75].scale.x * this.boneID2SrcPose[77].scale.x * this.boneID2SrcPose[73].scale.x, 1f, this.boneID2SrcPose[75].scale.z * this.boneID2SrcPose[77].scale.z * this.boneID2SrcPose[73].scale.z);
            this.boneID2DstPose[34].trfBone.SetLocalScale(this.boneID2SrcPose[76].scale.x * this.boneID2SrcPose[78].scale.x * this.boneID2SrcPose[74].scale.x, 1f, this.boneID2SrcPose[76].scale.z * this.boneID2SrcPose[78].scale.z * this.boneID2SrcPose[74].scale.z);
            this.boneID2DstPose[19].trfBone.SetLocalPositionZ(this.boneID2SrcPose[41].pos.z);
            this.boneID2DstPose[19].trfBone.SetLocalScale(this.boneID2SrcPose[41].scale.x, 1f, this.boneID2SrcPose[41].scale.z);
            this.boneID2DstPose[20].trfBone.SetLocalPositionZ(this.boneID2SrcPose[42].pos.z);
            this.boneID2DstPose[20].trfBone.SetLocalScale(this.boneID2SrcPose[42].scale.x, 1f, this.boneID2SrcPose[42].scale.z);
            this.boneID2DstPose[21].trfBone.SetLocalPositionZ(this.boneID2SrcPose[45].pos.z);
            this.boneID2DstPose[21].trfBone.SetLocalScale(this.boneID2SrcPose[47].scale.x * this.boneID2SrcPose[45].scale.x * this.boneID2SrcPose[43].scale.x, 1f, this.boneID2SrcPose[47].scale.z * this.boneID2SrcPose[45].scale.z * this.boneID2SrcPose[43].scale.z);
            this.boneID2DstPose[22].trfBone.SetLocalPositionZ(this.boneID2SrcPose[46].pos.z);
            this.boneID2DstPose[22].trfBone.SetLocalScale(this.boneID2SrcPose[48].scale.x * this.boneID2SrcPose[46].scale.x * this.boneID2SrcPose[44].scale.x, 1f, this.boneID2SrcPose[48].scale.z * this.boneID2SrcPose[46].scale.z * this.boneID2SrcPose[44].scale.z);
            this.boneID2DstPose[23].trfBone.SetLocalRotation(this.boneID2SrcPose[51].rot.x, 0f, 0f);
            this.boneID2DstPose[23].trfBone.SetLocalScale(this.boneID2SrcPose[49].scale.x * this.boneID2SrcPose[51].scale.x, 1f, this.boneID2SrcPose[49].scale.z * this.boneID2SrcPose[51].scale.z);
            this.boneID2DstPose[24].trfBone.SetLocalRotation(this.boneID2SrcPose[52].rot.x, 0f, 0f);
            this.boneID2DstPose[24].trfBone.SetLocalScale(this.boneID2SrcPose[50].scale.x * this.boneID2SrcPose[52].scale.x, 1f, this.boneID2SrcPose[50].scale.z * this.boneID2SrcPose[52].scale.z);
            this.boneID2DstPose[25].trfBone.SetLocalScale(this.boneID2SrcPose[53].scale.x * this.boneID2SrcPose[55].scale.x, 1f, this.boneID2SrcPose[53].scale.z * this.boneID2SrcPose[55].scale.z);
            this.boneID2DstPose[26].trfBone.SetLocalScale(this.boneID2SrcPose[54].scale.x * this.boneID2SrcPose[56].scale.x, 1f, this.boneID2SrcPose[54].scale.z * this.boneID2SrcPose[56].scale.z);
            this.boneID2DstPose[27].trfBone.SetLocalPositionX(this.boneID2SrcPose[57].pos.x);
            this.boneID2DstPose[27].trfBone.SetLocalPositionZ(this.boneID2SrcPose[57].pos.z);
            this.boneID2DstPose[27].trfBone.SetLocalRotation(this.boneID2SrcPose[57].rot.x, 0f, this.boneID2SrcPose[57].rot.z);
            this.boneID2DstPose[27].trfBone.SetLocalScale(this.boneID2SrcPose[57].scale.x, 1f, this.boneID2SrcPose[57].scale.z);
            this.boneID2DstPose[28].trfBone.SetLocalPositionX(this.boneID2SrcPose[58].pos.x);
            this.boneID2DstPose[28].trfBone.SetLocalPositionZ(this.boneID2SrcPose[57].pos.z);
            this.boneID2DstPose[28].trfBone.SetLocalRotation(this.boneID2SrcPose[58].rot.x, 0f, this.boneID2SrcPose[58].rot.z);
            this.boneID2DstPose[28].trfBone.SetLocalScale(this.boneID2SrcPose[58].scale.x, 1f, this.boneID2SrcPose[58].scale.z);
            this.boneID2DstPose[64].trfBone.SetLocalPosition(this.boneID2SrcPose[146].pos.x, this.boneID2SrcPose[148].pos.y + this.boneID2SrcPose[146].pos.y, this.boneID2SrcPose[144].pos.z + this.boneID2SrcPose[146].pos.z);
            this.boneID2DstPose[64].trfBone.SetLocalRotation(this.boneID2SrcPose[148].rot.x, 0f, 0f);
            this.boneID2DstPose[64].trfBone.SetLocalScale(this.boneID2SrcPose[142].scale.x * this.boneID2SrcPose[144].scale.x * this.boneID2SrcPose[146].scale.x, this.boneID2SrcPose[146].scale.y, this.boneID2SrcPose[140].scale.z * this.boneID2SrcPose[142].scale.z * this.boneID2SrcPose[144].scale.z * this.boneID2SrcPose[146].scale.z);
            this.boneID2DstPose[65].trfBone.SetLocalPosition(this.boneID2SrcPose[147].pos.x, this.boneID2SrcPose[149].pos.y + this.boneID2SrcPose[147].pos.y, this.boneID2SrcPose[145].pos.z + this.boneID2SrcPose[147].pos.z);
            this.boneID2DstPose[65].trfBone.SetLocalRotation(this.boneID2SrcPose[149].rot.x, 0f, 0f);
            this.boneID2DstPose[65].trfBone.SetLocalScale(this.boneID2SrcPose[143].scale.x * this.boneID2SrcPose[145].scale.x * this.boneID2SrcPose[147].scale.x, this.boneID2SrcPose[147].scale.y, this.boneID2SrcPose[141].scale.z * this.boneID2SrcPose[143].scale.z * this.boneID2SrcPose[145].scale.z * this.boneID2SrcPose[147].scale.z);
            this.boneID2DstPose[82].trfBone.SetLocalPositionY(num + num3);
            this.boneID2DstPose[82].trfBone.SetLocalPositionZ(z + num4);
            this.boneID2DstPose[82].trfBone.SetLocalScale(x * num6 * this.boneID2SrcPose[207].scale.x, num2 * num5, x * num6);
            this.boneID2DstPose[83].trfBone.SetLocalPositionX(-num7);
            this.boneID2DstPose[83].trfBone.SetLocalPositionY(this.boneID2SrcPose[199].pos.y);
            this.boneID2DstPose[83].trfBone.SetLocalRotation(this.boneID2SrcPose[199].rot.x, 0f, -num8);
            this.boneID2DstPose[83].trfBone.SetLocalScale(x2, y, 1f);
            this.boneID2DstPose[84].trfBone.SetLocalPositionX(num7);
            this.boneID2DstPose[84].trfBone.SetLocalPositionY(this.boneID2SrcPose[199].pos.y);
            this.boneID2DstPose[84].trfBone.SetLocalRotation(this.boneID2SrcPose[199].rot.x, 0f, num8);
            this.boneID2DstPose[84].trfBone.SetLocalScale(x2, y, 1f);
            this.boneID2DstPose[85].trfBone.SetLocalPositionX(-(x3 + x4 + x6));
            this.boneID2DstPose[85].trfBone.SetLocalPositionY(y2 + y4);
            this.boneID2DstPose[85].trfBone.SetLocalPositionZ(num11 + z2 + z3 + z4);
            this.boneID2DstPose[85].trfBone.SetLocalRotation(x8, 0f, 0f);
            this.boneID2DstPose[85].trfBone.SetLocalScale(num9 * x5 * x7 * x9 / this.boneID2SrcPose[207].scale.x, num10 * y3, num9 * x5 * x7);
            this.boneID2DstPose[86].trfBone.SetLocalPositionX(x3 + x4 + x6);
            this.boneID2DstPose[86].trfBone.SetLocalPositionY(y2 + y4);
            this.boneID2DstPose[86].trfBone.SetLocalPositionZ(num11 + z2 + z3 + z4);
            this.boneID2DstPose[86].trfBone.SetLocalRotation(x8, 0f, 0f);
            this.boneID2DstPose[86].trfBone.SetLocalScale(num9 * x5 * x7 * x9 / this.boneID2SrcPose[207].scale.x, num10 * y3, num9 * x5 * x7);
        }
    }
}
