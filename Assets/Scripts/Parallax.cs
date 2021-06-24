using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

	GameObject player;
	Vector3 lastPos, offset;
	public float speed;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
		lastPos = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		offset = player.transform.position - lastPos;
		transform.Translate (offset * speed * Time.deltaTime);
		lastPos = player.transform.position;
	}
}
