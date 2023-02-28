using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealthText : MonoBehaviour
{
    private TextMeshProUGUI playerHealthText;

    private void Awake()
    {
        playerHealthText= GetComponent<TextMeshProUGUI>();
    }
    private void OnEnable()
    {

    }
    private void OnDisable()
    {

    }

    private void SetPlayerHealthText(int currentHealth) => playerHealthText.text = "HP:" + currentHealth;
}
