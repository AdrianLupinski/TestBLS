using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static event Action<int> OnHealthChange;

    [SerializeField]
    private int maxHealth;

    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        OnHealthChange?.Invoke(maxHealth);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        currentHealth--;
        OnHealthChange?.Invoke(currentHealth);
        if (currentHealth <= 0)
            SceneManager.LoadScene("MainMenu");
    }
}
