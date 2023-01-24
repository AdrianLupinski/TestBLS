using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    [SerializeField]
    private string levelName;

    private void Update()
    {
        LoadGameScene();
    }

    private void LoadGameScene()
    {
        if (Input.anyKeyDown)
            SceneManager.LoadScene(levelName);
    }
}
