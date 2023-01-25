using UnityEngine;
using TMPro;
public class LastGameScoreText : MonoBehaviour
{
    TextMeshProUGUI lastGameScoreText;


    private void OnEnable()
    {
        UpdateLastScore.OnUpdateLastScoreText += UpdateLastGameScoreText;
    }

    private void OnDisable()
    {
        UpdateLastScore.OnUpdateLastScoreText -= UpdateLastGameScoreText;
    }

    private void UpdateLastGameScoreText(int lastscore)
    {
        lastGameScoreText = GetComponent<TextMeshProUGUI>();
        lastGameScoreText.text = "Last Game Score: " + lastscore;
    }
}
