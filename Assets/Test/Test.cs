using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public List<int> list;

    public Test()
    {
        Debug.Log(Test1.Instance.text);
    }
}

public class Test1 : Singleton<Test1>
{
    public string text = "55";
}
