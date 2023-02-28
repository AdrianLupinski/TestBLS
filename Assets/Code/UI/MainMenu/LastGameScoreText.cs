using UnityEngine;
using TMPro;
public class LastGameScoreText : MonoBehaviour
{
    TextMeshProUGUI lastGameScoreText;


    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    private void UpdateLastGameScoreText(int lastscore)
    {
        lastGameScoreText = GetComponent<TextMeshProUGUI>();
        lastGameScoreText.text = "Last Game Score: " + PlayerPrefs.GetInt("");
    }
}
