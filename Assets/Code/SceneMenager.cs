using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenager : MonoBehaviour
{
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

    private void LoadGameScene() => SceneManager.LoadScene(levelName);

}
