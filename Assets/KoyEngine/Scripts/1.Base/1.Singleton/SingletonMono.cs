using System;
using UnityEngine;

public class SingletonMono<T>:MonoBehaviour where T:SingletonMono<T>
{
    public static T Instance;
    protected virtual void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = (T)this;
            DontDestroyOnLoad(this);
        }
    }
}