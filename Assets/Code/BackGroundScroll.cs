using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    [SerializeField]
    private float scrollSpeed = 0.2f;

    private Renderer re;

    private void Start()
    {
        re = GetComponent<Renderer>();
    }
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * scrollSpeed, transform.position.y);
        re.material.mainTextureOffset= offset;
    }
}
