using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour {

	public float speed;
	public Transform endPoint;
	Vector3 startPoint;
	Rigidbody2D rb;
	float currentSpeed;

	// Use this for initialization
	void Start () {
		startPoint = transform.position;
		rb = GetComponent<Rigidbody2D> ();
		currentSpeed = speed;
	}

	void FixedUpdate() {
		if (transform.position.y > endPoint.position.y) 
			currentSpeed = -speed;
		if (transform.position.y < startPoint.y) 
				currentSpeed = speed;
		rb.velocity = new Vector3 (0, currentSpeed, 0);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
