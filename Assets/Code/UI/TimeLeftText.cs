using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeLeftText : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private int timeLeft;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        TimeMenager.OnTimeTextUpdate += UpdateTimeLeftText;
    }

    private void OnDisable()
    {
        TimeMenager.OnTimeTextUpdate -= UpdateTimeLeftText;
    }

    private void UpdateTimeLeftText(int currentTime)
    {
        timeLeft = currentTime;
        SetTimeText();
    }

    private void SetTimeText() => scoreText.text = "Time Left: " + timeLeft;
}
