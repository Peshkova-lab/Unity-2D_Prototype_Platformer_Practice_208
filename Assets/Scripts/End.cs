using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End : MonoBehaviour {
	
	public Button buttonExit;
	public AudioSource btn_click_sound;

	// Use this for initialization
	void Start () {
		buttonExit.onClick.AddListener (goToExit);
	}

	void goToExit() {
		btn_click_sound.Play ();
		Application.Quit();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
