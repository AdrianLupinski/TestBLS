using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class UpdateLastScore : MonoBehaviour
{
    public static event Action<int> OnUpdateLastScoreText;

    private int lastScore;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        Score.OnUpdateLastGameScore += UpdateScore;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        Score.OnUpdateLastGameScore -= UpdateScore;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode) => OnUpdateLastScoreText?.Invoke(lastScore);

    private void UpdateScore(int lastscore) => this.lastScore = lastscore;
}

