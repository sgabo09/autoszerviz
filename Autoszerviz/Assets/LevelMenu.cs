using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public string level1, level2;
    private void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 3, Screen.width / 5, Screen.height / 10), "Level 1"))
        {
            SceneManager.LoadScene(level1,LoadSceneMode.Single);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f,  Screen.height / 2, Screen.width / 5, Screen.height / 10), "Level 2"))
        {
            SceneManager.LoadScene(level2,LoadSceneMode.Single);
        }
       

    }
}