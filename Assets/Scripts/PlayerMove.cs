using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public LayerMask whatIsGround;
	public Transform groundCheck;
	public bool isGrounded;
	public float jumpForce;
	public float speed;

	Rigidbody2D rb;
	public bool isLookingLeft;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();	
	}

	void FixedUpdate() {
		isGrounded = Physics2D.OverlapPoint (groundCheck.position, whatIsGround);

		float x = Input.GetAxis ("Horizontal");

		Vector3 move = new Vector3 (x * speed, rb.velocity.y, 0f);

		rb.velocity = move;

		if (x < 0 && !isLookingLeft)
			TurnTheGirl ();

		if (x > 0 && isLookingLeft)
			TurnTheGirl ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") && isGrounded) {
			rb.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
			isGrounded = false;
		}
	}

	void TurnTheGirl() {
		isLookingLeft = !isLookingLeft;
		transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
	}
}
