using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			SceneManager.LoadScene ("Final");
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
