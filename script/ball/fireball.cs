using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour {
	public float speed;

	void Start () {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (0, speed);
		gameObject.GetComponent<attack> ().atk = data.fireball.atk;
	}
	void OnCollisionEnter2D (Collision2D col){
		Destroy (gameObject);
	}
}
