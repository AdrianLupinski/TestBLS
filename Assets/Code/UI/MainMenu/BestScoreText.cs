using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScoreText : MonoBehaviour
{
    TextMeshProUGUI bestScoreText;

    private void Start()
    {
        bestScoreText= GetComponent<TextMeshProUGUI>();
        SetBestScoreText();
    }

    private void SetBestScoreText()
    {
        bestScoreText.text = "Best Score: " + PlayerPrefs.GetInt("Score");
    }
}
