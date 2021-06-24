using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour {

	public AudioClip footsteps;

	public void FootStepsAudio () {
		AudioSource.PlayClipAtPoint (footsteps, transform.position);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ground") {
			AudioSource.PlayClipAtPoint (footsteps, transform.position);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
