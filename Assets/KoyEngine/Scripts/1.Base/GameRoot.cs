using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoot : SingletonMono<GameRoot>
{
    protected override void Awake()
    {
        base.Awake();
        InitManager();
    }
    
    private void InitManager()
    {
        ManagerBase[] managers = GetComponents<ManagerBase>();
        foreach (var manager in managers)
        {
            manager.Init();
        }
    }
}
