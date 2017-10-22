using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
    private void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width/2.5f, Screen.height/5,Screen.width/5,Screen.height/10),"New Game"))
        {
            Application.LoadLevel(3);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f, 2*Screen.height /5, Screen.width / 5, Screen.height / 10), "Settings"))
        {
            Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f,3* Screen.height / 5, Screen.width / 5, Screen.height / 10), "High Score"))
        {
            Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f, 4*Screen.height / 5, Screen.width / 5 , Screen.height / 10), "Quit"))
        {
            Application.Quit();
        }

    }
}
