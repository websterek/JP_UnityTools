using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorExtension
{
    #region Vector2 RotateAroundPivot
    public static Vector2 RotateAroundPivot(this Vector2 _vector2, Vector2 pivot, float angle)
    {
        return RotateAroundPivot(_vector2, pivot, Quaternion.Euler(Vector3.back * angle));
    }
    #endregion


    #region Vector2Int RotateAroundPivot
    public static Vector2 RotateAroundPivot(this Vector2Int _vector2, Vector2 pivot, float angle)
    {
        return RotateAroundPivot(_vector2, pivot, angle);
    }
    #endregion


    #region Vector3 RotateAroundPivot
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


    #region Vector3Int RotateAroundPivot
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


    #region Vector3 Mathf
    public static Vector2 Abs(this Vector3 _vector3)
    {
        float x = Mathf.Abs(_vector3.x);
        float y = Mathf.Abs(_vector3.y);
        float z = Mathf.Abs(_vector3.z);
        return new Vector3(x, y, z);
    }

    public static Vector3 Ceil(this Vector3 _vector3)
    {
        float x = Mathf.Ceil(_vector3.x);
        float y = Mathf.Ceil(_vector3.y);
        float z = Mathf.Ceil(_vector3.z);
        return new Vector3(x, y, z);
    }

    public static Vector3 Floor(this Vector3 _vector3)
    {
        float x = Mathf.Floor(_vector3.x);
        float y = Mathf.Floor(_vector3.y);
        float z = Mathf.Floor(_vector3.z);
        return new Vector3(x, y, z);
    }

    public static Vector3 Round(this Vector3 _vector3)
    {
        float x = Mathf.Round(_vector3.x);
        float y = Mathf.Round(_vector3.y);
        float z = Mathf.Round(_vector3.z);
        return new Vector3(x, y, z);
    }

    public static Vector3Int RoundToInt(this Vector3 _vector3)
    {
        int x = Mathf.RoundToInt(_vector3.x);
        int y = Mathf.RoundToInt(_vector3.y);
        int z = Mathf.RoundToInt(_vector3.z);
        return new Vector3Int(x, y, z);
    }

    public static Vector3 Mod(this Vector3 _vector3, Vector3 vector)
    {
        float x = _vector3.x % vector.x;
        float y = _vector3.y % vector.y;
        float z = _vector3.z % vector.z;
        return new Vector3(x, y, z);
    }

    public static Vector3 Mod(this Vector3 _vector3, float vector)
    {
        float x = _vector3.x % vector;
        float y = _vector3.y % vector;
        float z = _vector3.z % vector;
        return new Vector3(x, y, z);
    }

    public static Vector3 RoundToClosest(this Vector3 _vector3, Vector3 closest)
    {
        float x = Mathf.Round(_vector3.x / closest.x) * closest.x;
        float y = Mathf.Round(_vector3.y / closest.y) * closest.y;
        float z = Mathf.Round(_vector3.z / closest.z) * closest.z;
        return new Vector3(x, y, z);
    }

    public static Vector3 RoundToClosest(this Vector3 _vector3, float closest)
    {
        float x = Mathf.Round(_vector3.x / closest) * closest;
        float y = Mathf.Round(_vector3.y / closest) * closest;
        float z = Mathf.Round(_vector3.z / closest) * closest;
        return new Vector3(x, y, z);
    }
    #endregion


    #region Vector3Int Mathf
    public static Vector3Int Ceil(this Vector3Int _vector3)
    {
        int x = Mathf.CeilToInt(_vector3.x);
        int y = Mathf.CeilToInt(_vector3.y);
        int z = Mathf.CeilToInt(_vector3.z);
        return new Vector3Int(x, y, z);
    }

    public static Vector3Int Floor(this Vector3Int _vector3)
    {
        int x = Mathf.FloorToInt(_vector3.x);
        int y = Mathf.FloorToInt(_vector3.y);
        int z = Mathf.FloorToInt(_vector3.z);
        return new Vector3Int(x, y, z);
    }

    public static Vector3Int Mod(this Vector3Int _vector3, Vector3Int vector)
    {
        int x = _vector3.x % vector.x;
        int y = _vector3.y % vector.y;
        int z = _vector3.z % vector.z;
        return new Vector3Int(x, y, z);
    }

    public static Vector3Int Mod(this Vector3Int _vector3, int vector)
    {
        int x = _vector3.x % vector;
        int y = _vector3.y % vector;
        int z = _vector3.z % vector;
        return new Vector3Int(x, y, z);
    }

    public static Vector3Int Round(this Vector3Int _vector3)
    {
        int x = Mathf.RoundToInt(_vector3.x);
        int y = Mathf.RoundToInt(_vector3.y);
        int z = Mathf.RoundToInt(_vector3.z);
        return new Vector3Int(x, y, z);
    }

    public static Vector3Int RoundToClosest(this Vector3Int _vector3, Vector3Int closest)
    {
        int x = Mathf.RoundToInt(_vector3.x / closest.x) * closest.x;
        int y = Mathf.RoundToInt(_vector3.y / closest.y) * closest.y;
        int z = Mathf.RoundToInt(_vector3.z / closest.z) * closest.z;
        return new Vector3Int(x, y, z);
    }

    public static Vector3Int RoundToClosest(this Vector3Int _vector3, int closest)
    {
        int x = Mathf.RoundToInt(_vector3.x / closest) * closest;
        int y = Mathf.RoundToInt(_vector3.y / closest) * closest;
        int z = Mathf.RoundToInt(_vector3.z / closest) * closest;
        return new Vector3Int(x, y, z);
    }
    #endregion


    #region Vector2 Mathf
    public static Vector2 Ceil(this Vector2 _vector2)
    {
        float x = Mathf.Ceil(_vector2.x);
        float y = Mathf.Ceil(_vector2.y);
        return new Vector3(x, y);
    }

    public static Vector2 Floor(this Vector2 _vector2)
    {
        float x = Mathf.Floor(_vector2.x);
        float y = Mathf.Floor(_vector2.y);
        return new Vector3(x, y);
    }

    public static Vector2 Mod(this Vector2 _vector2, Vector2 vector)
    {
        float x = _vector2.x % vector.x;
        float y = _vector2.y % vector.y;
        return new Vector2(x, y);
    }

    public static Vector2 Mod(this Vector2 _vector2, float vector)
    {
        float x = _vector2.x % vector;
        float y = _vector2.y % vector;
        return new Vector2(x, y);
    }

    public static Vector2 Round(this Vector2 _vector2)
    {
        float x = Mathf.Round(_vector2.x);
        float y = Mathf.Round(_vector2.y);
        return new Vector2(x, y);
    }

    public static Vector2Int RoundToInt(this Vector2 _vector2)
    {
        int x = Mathf.RoundToInt(_vector2.x);
        int y = Mathf.RoundToInt(_vector2.y);
        return new Vector2Int(x, y);
    }

    public static Vector2 RoundToClosest(this Vector2 _vector2, Vector2 closest)
    {
        float x = Mathf.Round(_vector2.x / closest.x) * closest.x;
        float y = Mathf.Round(_vector2.y / closest.y) * closest.y;
        return new Vector2(x, y);
    }

    public static Vector3 RoundToClosest(this Vector2 _vector2, float closest)
    {
        float x = Mathf.Round(_vector2.x / closest) * closest;
        float y = Mathf.Round(_vector2.y / closest) * closest;
        return new Vector2(x, y);
    }

    public static Vector3 Clamp(this Vector3 _vector3, Vector3 min, Vector3 max)
    {
        float x = Mathf.Clamp(_vector3.x, min.x, max.x);
        float y = Mathf.Clamp(_vector3.y, min.y, max.y);
        float z = Mathf.Clamp(_vector3.z, min.z, max.z);
        return new Vector3(x, y, z);
    }

    public static Vector3 Clamp(this Vector3 _vector3, float min, float max)
    {
        float x = Mathf.Clamp(_vector3.x, min, max);
        float y = Mathf.Clamp(_vector3.y, min, max);
        float z = Mathf.Clamp(_vector3.z, min, max);
        return new Vector3(x, y, z);
    }
    #endregion


    #region Vector2Int Mathf
    public static Vector2Int Ceil(this Vector2Int _vector2)
    {
        int x = Mathf.CeilToInt(_vector2.x);
        int y = Mathf.CeilToInt(_vector2.y);
        return new Vector2Int(x, y);
    }

    public static Vector2Int Floor(this Vector2Int _vector2)
    {
        int x = Mathf.FloorToInt(_vector2.x);
        int y = Mathf.FloorToInt(_vector2.y);
        return new Vector2Int(x, y);
    }

    public static Vector2Int Mod(this Vector2Int _vector2, Vector2Int vector)
    {
        int x = _vector2.x % vector.x;
        int y = _vector2.y % vector.y;
        return new Vector2Int(x, y);
    }

    public static Vector2Int Mod(this Vector2Int _vector2, int vector)
    {
        int x = _vector2.x % vector;
        int y = _vector2.y % vector;
        return new Vector2Int(x, y);
    }

    public static Vector2Int Round(this Vector2Int _vector2)
    {
        int x = Mathf.RoundToInt(_vector2.x);
        int y = Mathf.RoundToInt(_vector2.y);
        return new Vector2Int(x, y);
    }

    public static Vector2Int RoundToClosest(this Vector2Int _vector2, Vector2Int closest)
    {
        int x = Mathf.RoundToInt(_vector2.x / closest.x) * closest.x;
        int y = Mathf.RoundToInt(_vector2.y / closest.y) * closest.y;
        return new Vector2Int(x, y);
    }

    public static Vector2Int RoundToClosest(this Vector2Int _vector2, int closest)
    {
        int x = Mathf.RoundToInt(_vector2.x / closest) * closest;
        int y = Mathf.RoundToInt(_vector2.y / closest) * closest;
        return new Vector2Int(x, y);
    }

    public static Vector2 Clamp(this Vector2 _vector2, Vector2 min, Vector2 max)
    {
        float x = Mathf.Clamp(_vector2.x, min.x, max.x);
        float y = Mathf.Clamp(_vector2.y, min.y, max.y);
        return new Vector2(x, y);
    }

    public static Vector2 Clamp(this Vector2 _vector2, float min, float max)
    {
        float x = Mathf.Clamp(_vector2.x, min, max);
        float y = Mathf.Clamp(_vector2.y, min, max);
        return new Vector2(x, y);
    }
    #endregion


    #region Transform RotateAroundPivot
    // public static void RotateAroundPivot(this Transform _transform, Vector3 pivot, Quaternion angle)
    // {
    //     _transform.position = _transform.position.RotateAroundPivot(pivot, angle);
    // }

    // public static void RotateAroundPivot(this Transform _transform, Vector3 pivot, Vector3 euler)
    // {
    //     _transform.position = _transform.position.RotateAroundPivot(pivot, Quaternion.Euler(euler));
    // }

    // public static void RotateAroundPivot(this Transform _transform, Vector3 pivot, Vector3 axis, float angle)
    // {
    //     _transform.position = _transform.position.RotateAroundPivot(pivot, axis, angle);
    // }
    #endregion


    // RotateArounfPivot idea borrowed from: http://answers.unity.com/answers/957394/view.htmls
}