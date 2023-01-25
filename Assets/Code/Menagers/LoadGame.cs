using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
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
