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
    private void OnEnable()
    {
        StartCoroutine("FollowPath");
    }
    private void Update()
    {
    }

    private IEnumerator FollowPath()
    {
        for (int i = 0; i < Screen.width; i++)
        {
            transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y, transform.position.z);
            yield return new WaitForSeconds(Time.deltaTime);
        }

        Destroy(this.gameObject);

    }
}
