using UnityEngine;
using System;

public class EnemyHealth : MonoBehaviour
{
    public static event Action<int> OnEnemyKill;

    [SerializeField]
    private int scoreToAdd;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Weapon")
        {
            Destroy(collision.gameObject);
            OnEnemyKill?.Invoke(scoreToAdd);
            Destroy(this.gameObject);
        }
    }
}
