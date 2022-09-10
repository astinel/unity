using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antball : MonoBehaviour {
	public float speed;

	void Start(){
		Rigidbody2D rb;
		Transform tr;
		Transform mp;

		tr = transform.parent.Find ("antqueen");
		transform.position = tr.position + Vector3.down;
		rb = GetComponent<Rigidbody2D> ();
		mp = GameObject.Find ("Move Panel").transform;
		rb.velocity = Vector3.MoveTowards (transform.position, mp.position, speed) - transform.position;
	}
	void OnTriggerEnter2D (Collider2D col){
		Debug.Log ("충돌");
		if (col.gameObject.layer == 8) {
			Debug.Log ("충돌2");
		}
		Destroy (gameObject);
	}
}