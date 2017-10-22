using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenu : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 3, Screen.width / 5, Screen.height / 10), "Level 1"))
        {
            Application.LoadLevel(0);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f,  Screen.height / 2, Screen.width / 5, Screen.height / 10), "Level 2"))
        {
            Application.LoadLevel(1);
        }
       

    }
}