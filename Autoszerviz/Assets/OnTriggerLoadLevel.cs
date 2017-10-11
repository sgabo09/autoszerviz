﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerLoadLevel : MonoBehaviour {

	public GameObject guiObject;
	public string level;

	// Use this for initialization
	void Start () {
		guiObject.SetActive (false);
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
		if (other.gameObject.tag == "Player") 
		{
			guiObject.SetActive (true);
			if(guiObject.activeInHierarchy == true && Input.GetButtonDown("Use"))
			{
				SceneManager.LoadScene (level, LoadSceneMode.Single);	
			}
		}
	}

	void OnTriggerExit () {
		guiObject.SetActive (false);
	}
}
