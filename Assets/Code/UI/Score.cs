using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
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
    }

    private void OnDisable()
    {
        Bullet.OnEnemyKill -= AddScorePoint;
    }

    private void AddScorePoint()
    {
        currentScore++;
        SetScoreText();
    }

    private void SetScoreText() => scoreText.text = "Score: " + currentScore;


}
