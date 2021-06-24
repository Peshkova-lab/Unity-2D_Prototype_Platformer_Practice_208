using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroyer : MonoBehaviour {

	public float timeToDestroy;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, timeToDestroy);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
