using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasWidth : MonoBehaviour
{
    private float width;

    private void Start()
    {
        width = Screen.width;
    }
    public Transform Canvas()
    {
        return this.transform;
    }
}
