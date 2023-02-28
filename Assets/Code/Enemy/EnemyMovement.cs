using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private float screenWidth;

    private void Start()
    {
        screenWidth = Screen.width;
        moveSpeed = moveSpeed - 2 * moveSpeed;
    }

    private void Update()
    {
        transform.localPosition = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.localPosition.z);

        if (transform.position.x < screenWidth)
        {
            Destroy(this.gameObject);
        }

    }
}
