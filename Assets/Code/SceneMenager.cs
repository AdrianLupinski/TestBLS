using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneMenager : MonoBehaviour
{
    public static event Action OnUpdateScore;
    [SerializeField]
    private string levelName;

    private void OnEnable()
    {
        PlayerHealth.OnPlayerDeath += LoadGameScene;
        TimeMenager.OnTimeUp += LoadGameScene;
    }
    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= LoadGameScene;
        TimeMenager.OnTimeUp -= LoadGameScene;
    }

    private void LoadGameScene()
    {
        OnUpdateScore?.Invoke();
        SceneManager.LoadScene(levelName);
    }
}
