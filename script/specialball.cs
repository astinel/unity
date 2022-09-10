using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specialball : MonoBehaviour {
	Vector3 up = new Vector2 (0, 4);
	Rigidbody2D rb;
	void Start(){
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = up;
	}
	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.name == "Top Wall") {
			Destroy (gameObject);
		} else if (col.gameObject.layer == 10) {
			game.blockcount--;
			col.gameObject.SetActive (false);
		}
	}
}
