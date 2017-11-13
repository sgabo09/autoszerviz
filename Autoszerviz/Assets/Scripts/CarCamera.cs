using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCamera : MonoBehaviour {

	public Camera frontCamera;
	public Camera rearCamera;
	public Camera closeCamera;
	public KeyCode key;
	public int var;

	// Use this for initialization
	void Start () {
		rearCamera.gameObject.SetActive (true);
		frontCamera.gameObject.SetActive (false);
		closeCamera.gameObject.SetActive (false);
		var = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(key)) {
			var++;
			if (var > 3) {
				var = 1;
			}
		}

		if (var == 1) {
			rearCamera.gameObject.SetActive (true);
			frontCamera.gameObject.SetActive (false);
			closeCamera.gameObject.SetActive (false);
		}else if(var == 2) {
			rearCamera.gameObject.SetActive (false);
			frontCamera.gameObject.SetActive (true);
			closeCamera.gameObject.SetActive (false);		
		}else if(var == 3) {
			rearCamera.gameObject.SetActive (false);
			frontCamera.gameObject.SetActive (false);
			closeCamera.gameObject.SetActive (true);		
		}

	}
}
