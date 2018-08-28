using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public static class Extension
{
    public static Transform FindLoop(this Transform transform, string name)
    {
        if (string.Compare(name, transform.gameObject.name) == 0)
        {
            return transform;
        }
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform tf = transform.GetChild(i).FindLoop(name);
            if (tf != null)
            {
                return tf;
            }
        }
        return null;
    }

    public static void SetLocalScaleX(this Transform transform, float x)
    {
        Vector3 localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
        transform.localScale = localScale;
    }

    public static void SetLocalScaleY(this Transform transform, float y)
    {
        Vector3 localScale = new Vector3(transform.localScale.x, y, transform.localScale.z);
        transform.localScale = localScale;
    }

    public static void SetLocalScaleZ(this Transform transform, float z)
    {
        Vector3 localScale = new Vector3(transform.localScale.x, transform.localScale.y, z);
        transform.localScale = localScale;
    }

    public static void SetLocalScale(this Transform transform, float x, float y, float z)
    {
        Vector3 localScale = new Vector3(x, y, z);
        transform.localScale = localScale;
    }

    public static void SetPositionX(this Transform transform, float x)
    {
        Vector3 position = new Vector3(x, transform.position.y, transform.position.z);
        transform.position = position;
    }

    public static void SetPositionY(this Transform transform, float y)
    {
        Vector3 position = new Vector3(transform.position.x, y, transform.position.z);
        transform.position = position;
    }

    public static void SetPositionZ(this Transform transform, float z)
    {
        Vector3 position = new Vector3(transform.position.x, transform.position.y, z);
        transform.position = position;
    }

    public static void SetPosition(this Transform transform, float x, float y, float z)
    {
        Vector3 position = new Vector3(x, y, z);
        transform.position = position;
    }

    public static void SetLocalPositionX(this Transform transform, float x)
    {
        Vector3 localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
        transform.localPosition = localPosition;
    }

    public static void SetLocalPositionY(this Transform transform, float y)
    {
        Vector3 localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
        transform.localPosition = localPosition;
    }

    public static void SetLocalPositionZ(this Transform transform, float z)
    {
        Vector3 localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
        transform.localPosition = localPosition;
    }

    public static void SetLocalPosition(this Transform transform, float x, float y, float z)
    {
        Vector3 localPosition = new Vector3(x, y, z);
        transform.localPosition = localPosition;
    }

    public static void SetRotationX(this Transform transform, float x)
    {
        Vector3 euler = new Vector3(x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        transform.rotation = Quaternion.Euler(euler);
    }

    public static void SetRotationY(this Transform transform, float y)
    {
        Vector3 euler = new Vector3(transform.rotation.eulerAngles.x, y, transform.rotation.eulerAngles.z);
        transform.rotation = Quaternion.Euler(euler);
    }

    public static void SetRotationZ(this Transform transform, float z)
    {
        Vector3 euler = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, z);
        transform.rotation = Quaternion.Euler(euler);
    }

    public static void SetRotation(this Transform transform, float x, float y, float z)
    {
        Vector3 euler = new Vector3(x, y, z);
        transform.rotation = Quaternion.Euler(euler);
    }

    public static void SetLocalRotationX(this Transform transform, float x)
    {
        Vector3 euler = new Vector3(x, transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z);
        transform.localRotation = Quaternion.Euler(euler);
    }

    public static void SetLocalRotationY(this Transform transform, float y)
    {
        Vector3 euler = new Vector3(transform.localRotation.eulerAngles.x, y, transform.localRotation.eulerAngles.z);
        transform.localRotation = Quaternion.Euler(euler);
    }

    public static void SetLocalRotationZ(this Transform transform, float z)
    {
        Vector3 euler = new Vector3(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y, z);
        transform.localRotation = Quaternion.Euler(euler);
    }

    public static void SetLocalRotation(this Transform transform, float x, float y, float z)
    {
        Vector3 euler = new Vector3(x, y, z);
        transform.localRotation = Quaternion.Euler(euler);
    }
}
