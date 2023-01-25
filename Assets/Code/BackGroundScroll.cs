using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    [SerializeField]
    private float scrollSpeed = 0.5f;

    Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * scrollSpeed, transform.position.y);
        renderer.material.mainTextureOffset= offset;
        
    }
}
