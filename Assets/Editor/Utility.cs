using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

static class Utility
{
    [MenuItem("Test/TraceBone")]
    static void Test()
    {
        GameObject go = Selection.activeGameObject;
        if (go == null)
            return;

        var childs = go.GetComponentsInChildren<Transform>();
        StringBuilder sb = new StringBuilder();
        foreach (var bone in childs)
        {
            sb.AppendFormat("{0}\t{1}\n", bone.name, bone.transform.parent != null ? bone.transform.parent.name : "");
        }
        Debug.Log(sb.ToString());
    }
}
