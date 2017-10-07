using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabPath : Attribute
{
    public string Path { get; set; }
    public PrefabPath(string path)
    {
        Path = path;
    }
}

public class PrefabGen<T> where T : class
{
    public static T Gen()
    {
        var t = typeof(T);
        
        var attrList = t.GetCustomAttributes(typeof(PrefabPath), false);
        foreach (var attr in attrList)
        {
            var prefabPath = attr as PrefabPath;
            if (prefabPath == null) continue;

            var prefab = Resources.Load(prefabPath.Path);
            if (prefab == null) continue;

            var instance = GameObject.Instantiate(prefab) as GameObject;
            if (instance == null) continue;

            return instance.GetComponent<T>();
        }

        return null;
    }
}