using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MushroomController : MonoBehaviour {

	public GameObject Explosion;
	public AudioClip Boom;

	public float distanceToRun;
	public float speed;
	public bool isLookingLeft = true;
	Vector3 startPos;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		startPos = transform.position;
		distanceToRun = distanceToRun * distanceToRun;
	
	}

	void FixedUpdate() {
		if (isLookingLeft) {
			Vector2 dist = transform.position - startPos;
			if (transform.position.x < startPos.x && dist.sqrMagnitude > distanceToRun) {
				TurnTheEnemy ();
				rb.velocity = new Vector2 (speed, rb.velocity.y);
			} else {
				rb.velocity = new Vector2 (-speed, rb.velocity.y);
			}
		}
		if (!isLookingLeft) {
			Vector2 dist = transform.position - startPos;
			if (transform.position.x > startPos.x && dist.sqrMagnitude > distanceToRun) {
				TurnTheEnemy ();
				rb.velocity = new Vector2 (-speed, rb.velocity.y);
			} else {
				rb.velocity = new Vector2 (speed, rb.velocity.y);
			}
		}
	}

	void TurnTheEnemy() {
		isLookingLeft = !isLookingLeft;
		transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.collider.gameObject.tag == "Player") {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			Instantiate (Explosion, transform.position, Quaternion.identity);
			AudioSource.PlayClipAtPoint(Boom, transform.position);
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
