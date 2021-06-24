using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour {

	public GameObject TextObject;

	Text textComponent;

	public AudioClip CoinSound;

	public int skull;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Coin") {
			skull = skull + 1;
			AudioSource.PlayClipAtPoint (CoinSound, transform.position);
			textComponent.text = skull.ToString ();
			Destroy (other.gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		textComponent = TextObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
