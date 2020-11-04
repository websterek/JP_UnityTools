#define DEBUG_LOG_OVERWRAP

using UnityEngine;

#if DEBUG_LOG_OVERWRAP
public static class Debug
{
    #region Debug Standard
    public static void Break()
    {
        if (IsEnable())
        {
            UnityEngine.Debug.Break();
        }
    }

    public static void ClearDeveloperConsole()
    {
        if (IsEnable())
        {
            UnityEngine.Debug.ClearDeveloperConsole();
        }
    }

    public static void DebugBreak()
    {
        if (IsEnable())
        {
            UnityEngine.Debug.DebugBreak();
        }
    }

    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.DrawLine(start, end, color, duration);
        }
    }

    public static void DrawLine(Vector3 start, Vector3 end, Color color)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.DrawLine(start, end, color);
        }
    }

    public static void DrawLine(Vector3 start, Vector3 end)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.DrawLine(start, end);
        }
    }

    public static void DrawLine(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.DrawLine(start, dir, color, duration, depthTest);
        }
    }

    public static void DrawRay(Vector3 start, Vector3 dir)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.DrawLine(start, dir);
        }
    }

    public static void Log(object message)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.Log(message);
        }
    }

    public static void Log(object message, Object context)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.Log(message, context);
        }
    }

    public static void LogAssertion(object message)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogAssertion(message);
        }
    }

    public static void LogAssertionFormat(Object context, string format, params object[] args)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogAssertionFormat(context, format, args);
        }
    }

    public static void LogAssertionFormat(string format, params object[] args)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogAssertionFormat(format, args);
        }
    }

    public static void LogError(object message, Object context)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogError(message, context);
        }
    }

    public static void LogError(object message)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogError(message);
        }
    }

    public static void LogErrorFormat(Object context, string format, params object[] args)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogErrorFormat(context, format, args);
        }
    }

    public static void LogErrorFormat(string format, params object[] args)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogErrorFormat(format, args);
        }
    }

    public static void LogException(System.Exception exception)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogException(exception);
        }
    }

    public static void LogException(System.Exception exception, Object context)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogException(exception, context);
        }
    }

    public static void LogFormat(string format, params object[] args)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogFormat(format, args);
        }
    }

    public static void LogFormat(Object context, string format, params object[] args)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogFormat(context, format, args);
        }
    }

    public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogFormat(logType, logOptions, context, format, args);
        }
    }

    public static void LogWarning(object message, Object context)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogWarning(message, context);
        }
    }

    public static void LogWarning(object message)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogWarning(message);
        }
    }

    public static void LogWarningFormat(Object context, string format, params object[] args)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogWarningFormat(context, format, args);
        }
    }

    public static void LogWarningFormat(string format, params object[] args)
    {
        if (IsEnable())
        {
            UnityEngine.Debug.LogWarningFormat(format, args);
        }
    }

    static bool IsEnable()
    {
        return UnityEngine.Debug.isDebugBuild;
    }
    #endregion


    #region Debug Extension
    static public void DrawBox(Vector3 point, Vector2 size, float angle, Color color, float duration = 0.0F, bool depthTest = true)
    {
        if (IsEnable())
        {
            size = size / 2;

            Vector3 LT = point + new Vector3(-size.x, size.y, 0);
            Vector3 RT = point + new Vector3(size.x, size.y, 0);
            Vector3 LD = point + new Vector3(-size.x, -size.y, 0);
            Vector3 RD = point + new Vector3(size.x, -size.y, 0);

            LT = LT.RotateAroundPivot(point, Vector3.back, angle);
            RT = RT.RotateAroundPivot(point, Vector3.back, angle);
            LD = LD.RotateAroundPivot(point, Vector3.back, angle);
            RD = RD.RotateAroundPivot(point, Vector3.back, angle);

            UnityEngine.Debug.DrawLine(LT, RT, color, duration, depthTest);
            UnityEngine.Debug.DrawLine(RT, RD, color, duration, depthTest);
            UnityEngine.Debug.DrawLine(RD, LD, color, duration, depthTest);
            UnityEngine.Debug.DrawLine(LD, LT, color, duration, depthTest);
        }
    }

    static public void DrawBox(Vector3 point, float size, float angle, Color color, float duration = 0.0F, bool depthTest = true)
    {
        if (IsEnable())
        {
            DrawBox(point, new Vector2(size, size), angle, color, duration, depthTest);
        }
    }

    static public void DrawCircle(Vector3 point, float radius, Color color, float duration = 0.0F, int segments = 16, bool depthTest = true)
    {
        Vector3 radiusArm = new Vector3(point.x, point.y + radius / 2, point.z);
        float angleStep = 360 / segments;

        Vector3 pointA;
        Vector3 pointB;

        for (float angle = 0; angle <= 360f; angle += angleStep)
        {
            pointA = Quaternion.Euler(Vector3.back * angle) * (radiusArm - point) + point;
            pointB = Quaternion.Euler(Vector3.back * (angle + angleStep)) * (radiusArm - point) + point;

            Debug.DrawLine(pointA, pointB, color, duration, depthTest);
        }


    }
    #endregion
}
#endif