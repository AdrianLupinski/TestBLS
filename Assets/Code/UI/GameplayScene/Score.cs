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
        scoreText= GetComponent<TextMeshProUGUI>();
        SetScoreText();
    }

    private void OnEnable()
    {
        Bullet.OnEnemyKill += AddScorePoint;
        SceneMenager.OnUpdateScore += UpdateScore;
    }

    private void OnDisable()
    {
        Bullet.OnEnemyKill -= AddScorePoint;
        SceneMenager.OnUpdateScore -= UpdateScore;
    }

    private void AddScorePoint()
    {
        currentScore++;
        SetScoreText();
    }

    private void SetScoreText() => scoreText.text = "Score: " + currentScore;

    private void UpdateScore()
    {
        if (currentScore > PlayerPrefs.GetInt("Score"))
          PlayerPrefs.SetInt("Score", currentScore);

        OnUpdateLastGameScore?.Invoke(currentScore);
    }
     

}
