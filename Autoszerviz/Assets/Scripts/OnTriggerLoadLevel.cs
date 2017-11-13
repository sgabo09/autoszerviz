using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class OnTriggerLoadLevel : MonoBehaviour {
    
	public GameObject enterText;
    public GameObject panel;
    public Button exitButton;
    public Button topSpeedPlusButton;
    public Text ts;
    public string level;
    public GameObject car;
    public CarController carController;
    public float topSpeed;


	// Use this for initialization
	void Start () {
		enterText.SetActive (false);
        panel.SetActive(false);
        topSpeedPlusButton.onClick.AddListener(TopSpeedPlus);
        Button btn = exitButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        carController = car.GetComponent<CarController>();
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
		if (other.gameObject.tag == "Player") 
		{
			enterText.SetActive (true);
			if(enterText.activeInHierarchy == true && Input.GetButtonDown("Use"))
			{
                panel.SetActive (true);
                enterText.SetActive (false);
                Time.timeScale = 0;
                topSpeed = carController.MaxSpeed;
                ts.text = "Current top speed: " + topSpeed;
			}
		}
	}

	void OnTriggerExit () {
		enterText.SetActive (false);
	}

    void TopSpeedPlus(){
        carController.m_Topspeed = carController.m_Topspeed + 50;
    }

    void TaskOnClick(){
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
