using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    [SerializeField]
    GameObject[] objs;
    void Awake()
    {
        objs = GameObject.FindGameObjectsWithTag("PlayerScore");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
