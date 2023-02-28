using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneMenager : MonoBehaviour
{

    [SerializeField]
    private string levelName;

    private void OnEnable()
    {
        Player.OnPlayerDeath += LoadGameScene;
        TimeMenager.OnTimeUp += LoadGameScene;
    }
    private void OnDisable()
    {
        Player.OnPlayerDeath -= LoadGameScene;
        TimeMenager.OnTimeUp -= LoadGameScene;
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene(levelName);
    }
}
