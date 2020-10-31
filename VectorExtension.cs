using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorExtension
{
    #region Vector3
    public static Vector3 RotateAroundPivot(this Vector3 _vector3, Vector3 pivot, Quaternion angle)
    {
        return angle * (_vector3 - pivot) + pivot;
    }

    public static Vector3 RotateAroundPivot(this Vector3 _vector3, Vector3 pivot, Vector3 euler)
    {
        return RotateAroundPivot(_vector3, pivot, Quaternion.Euler(euler));
    }

    public static Vector3 RotateAroundPivot(this Vector3 _vector3, Vector3 pivot, Vector3 axis, float angle)
    {
        return RotateAroundPivot(_vector3, pivot, Quaternion.Euler(axis * angle));
    }
    #endregion


    #region Vector3Int
    public static Vector3 RotateAroundPivot(this Vector3Int _vector3, Vector3 pivot, Quaternion angle)
    {
        return angle * (_vector3 - pivot) + pivot;
    }

    public static Vector3 RotateAroundPivot(this Vector3Int _vector3, Vector3 pivot, Vector3 euler)
    {
        return RotateAroundPivot(_vector3, pivot, Quaternion.Euler(euler));
    }

    public static Vector3 RotateAroundPivot(this Vector3Int _vector3, Vector3 pivot, Vector3 axis, float angle)
    {
        return RotateAroundPivot(_vector3, pivot, Quaternion.Euler(axis * angle));
    }
    #endregion


    #region Vector2
    public static Vector2 RotateAroundPivota(this Vector2 _vector2, Vector2 pivot, float angle)
    {
        return RotateAroundPivot(_vector2, pivot, Quaternion.Euler(Vector3.back * angle));
    }
    #endregion


    #region Vector2Int
    public static Vector2 RotateAroundPivot(this Vector2Int _vector2, Vector2 pivot, float angle)
    {
        return RotateAroundPivot(_vector2, pivot, angle);
    }
    #endregion


    #region Transform
    public static void RotateAroundPivot(this Transform _transform, Vector3 pivot, Quaternion angle)
    {
        _transform.position = _transform.position.RotateAroundPivot(pivot, angle);
    }

    public static void RotateAroundPivot(this Transform _transform, Vector3 pivot, Vector3 euler)
    {
        _transform.position = _transform.position.RotateAroundPivot(pivot, Quaternion.Euler(euler));
    }

    public static void RotateAroundPivot(this Transform _transform, Vector3 pivot, Vector3 axis, float angle)
    {
        _transform.position = _transform.position.RotateAroundPivot(pivot, axis, angle);
    }
    #endregion


    // idea borrowed from: http://answers.unity.com/answers/957394/view.htmls
}