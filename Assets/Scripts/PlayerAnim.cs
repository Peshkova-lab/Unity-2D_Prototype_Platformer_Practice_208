using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour {

	Animator anim;
	Rigidbody2D rb;
	PlayerMove pm;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
		pm = GetComponent<PlayerMove> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (pm.isGrounded) {
			anim.SetBool ("isJumping", false);
			anim.SetFloat ("speed", Mathf.Abs (rb.velocity.x));
		} else {
			anim.SetFloat ("speed", 0);
			anim.SetBool ("isJumping", true);
		}
	}
}
