using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bullet : MonoBehaviour
{
    public static event Action OnEnemyKill;


    [SerializeField]
    private float speed;
    [SerializeField]
    private int timeOfBulletLife;
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        StartCoroutine("DestroyBullet");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            OnEnemyKill?.Invoke();
            Destroy(this.gameObject);
        }
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(timeOfBulletLife);
        Destroy(this.gameObject);
    }
}
