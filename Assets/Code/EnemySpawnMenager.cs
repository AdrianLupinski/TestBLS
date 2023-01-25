using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class EnemySpawnMenager : MonoBehaviour
{
    [SerializeField]
    private Transform[] SpawnPlaces;

    [SerializeField]
    private GameObject[] enemys;


    [SerializeField]
    private int wavesCooldown;
    [SerializeField]
    private int wavesCount = 10;

    

    private void Start()
    {
        StartCoroutine("SpawnEnemys");
    }
    void Update()
    {
    }

    private void InstantiateEnemy()
    {
        int enemyToSpawnCount = Random.Range(2, 6);
        for (int i = 0; i < enemyToSpawnCount; i++)
        {
            int enemyIndex = Random.Range(1, enemys.Length);
            Instantiate(enemys[enemyIndex], SpawnPlaces[i]);
        }
    }

    IEnumerator SpawnEnemys()
    {
        for (int i = 0; i < wavesCount; i++)
        {
            InstantiateEnemy();
            yield return new WaitForSeconds(wavesCooldown);
        }
    }
}
