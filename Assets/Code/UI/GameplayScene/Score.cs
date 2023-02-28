using TMPro;
using UnityEngine;
using System;

public class Score : MonoBehaviour
{
    public static event Action<int> OnUpdateLastGameScore;

    private TextMeshProUGUI scoreText;
    private int currentScore;

    private void Awake()
    {
        currentScore = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
        SetScoreText();
    }

    private void OnEnable()
    {
        Enemy.OnEnemyKill += AddScorePoint;
        Player.OnPlayerDeath += UpdateScore;
        TimeMenager.OnTimeUp += UpdateScore;     
    }

    private void OnDisable()
    {
        Enemy.OnEnemyKill -= AddScorePoint;
        Player.OnPlayerDeath += UpdateScore;
        TimeMenager.OnTimeUp += UpdateScore;
    }

    private void AddScorePoint(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        SetScoreText();
    }

    private void SetScoreText() => scoreText.text = "Score: " + currentScore;

    private void UpdateScore()
    {
        if (currentScore > PlayerPrefs.GetInt("Score"))
          PlayerPrefs.SetInt("Score", currentScore); //This is for test, I should never youse PlayerPrefs for save stats

        OnUpdateLastGameScore?.Invoke(currentScore);
    }
     

}
