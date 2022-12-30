using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : ManagerBase<PoolManager>
{
    //根节点 对象池
    [SerializeField]
    private GameObject poolRootObj;

    private Dictionary<string, GameObjectPoolData> gameObjectPoolDic = new Dictionary<string, GameObjectPoolData>();
    public override void Init()
    {
        base.Init();
        Debug.Log("PoolManager Init");
    }
}
