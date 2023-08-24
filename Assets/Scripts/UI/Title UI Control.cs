using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUIControl : MonoBehaviour
{
    void Awake()
    {
        //roading Data
        DataManager.Instance.LoadGameData();
    }

    // New Game Button - Change Scene
    public void ChangeScene()
    {
        DataManager.Instance.data.pose = 0;

        DataManager.Instance.ApplyGameData();
        SceneManager.LoadScene("Map");
    }

    public void Continue()
    {
        DataManager.Instance.ApplyGameData();
        SceneManager.LoadScene("Map");
    }

    // Quit Button - Quit Game
    public void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}