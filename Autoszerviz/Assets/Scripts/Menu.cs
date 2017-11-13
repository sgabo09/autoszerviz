using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public string newGame, settings, highScore;

    private void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width/2.5f, Screen.height/5,Screen.width/5,Screen.height/10),"New Game"))
        {
            SceneManager.LoadScene(newGame, LoadSceneMode.Single);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f, 2*Screen.height /5, Screen.width / 5, Screen.height / 10), "Settings"))
        {
            SceneManager.LoadScene(settings, LoadSceneMode.Single);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f,3* Screen.height / 5, Screen.width / 5, Screen.height / 10), "High Score"))
        {
            SceneManager.LoadScene(highScore, LoadSceneMode.Single);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f, 4*Screen.height / 5, Screen.width / 5 , Screen.height / 10), "Quit"))
        {
            Application.Quit();
        }

    }
}
