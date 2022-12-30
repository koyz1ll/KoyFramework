using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public static class KoyExtension
{
    #region 通用

    public static T GetAttribute<T>(this object obj, Type type) where T : Attribute
    {
        return type.GetCustomAttribute<T>();
    }
    #endregion
}
