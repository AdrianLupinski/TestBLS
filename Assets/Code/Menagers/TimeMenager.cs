using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeMenager : MonoBehaviour
{
    public static event Action<int> OnTimeTextUpdate;
    public static event Action OnTimeUp;

    [SerializeField]
    private int timeOfLevel;
    private int currentTime;

    private void Awake()
    {
        currentTime = timeOfLevel;
    }

    private void Start()
    {
        StartCoroutine("StartTimeCooldown");
    }

    IEnumerator StartTimeCooldown() 
    {
        for (int i = 0;i < timeOfLevel; i++) 
        {
            currentTime--;
            OnTimeTextUpdate?.Invoke(currentTime);
            yield return new WaitForSeconds(1);
        }

        OnTimeUp?.Invoke();
    }
}

