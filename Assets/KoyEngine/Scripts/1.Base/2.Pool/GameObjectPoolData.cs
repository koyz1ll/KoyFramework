using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameObjectPoolData
{
    public GameObject parentObj;
    public Queue<GameObject> poolQueue;

    public GameObjectPoolData(GameObject patrent)
    {
        parentObj = new GameObject();
        poolQueue = new Queue<GameObject>();
    }
    public void Recovery(GameObject obj)
    {
        poolQueue.Enqueue(obj);
        obj.transform.parent = parentObj.transform;
        obj.SetActive(false);
    }

    public GameObject Get()
    {
        GameObject obj = poolQueue.Dequeue();
        obj.SetActive(true);
        obj.transform.parent = null;
        SceneManager.MoveGameObjectToScene(obj, SceneManager.GetActiveScene());
        return poolQueue.Dequeue();
    }
}
