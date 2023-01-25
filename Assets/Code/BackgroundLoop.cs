using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundLoop : MonoBehaviour
{
    public Image backgroundImage;
    private Camera mainCamera;
    private Vector2 screenBounds;

    private void Start()
    {
        mainCamera = GetComponent<Camera>();
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
    }

    private void SetImageSize()
    {
    }
}
