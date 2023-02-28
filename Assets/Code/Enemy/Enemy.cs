using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public static event Action<int> OnEnemyKill;

    [SerializeField]
    private int scoreToAdd;

    public void TakeDamage()
    {

    }
    
}
