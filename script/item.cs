using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {
	public GameObject go;
	public int code;
	Vector3 down;
	Rigidbody2D rb;
	float speed = -3;

	void Start(){
		down = new Vector2 (0, speed);
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = down;
	}
	void Update(){
		if (transform.position.y < -4) {
			Destroy (gameObject);
		}
	}
}