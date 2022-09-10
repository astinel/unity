using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ant : MonoBehaviour {
	public float speed;
	public int d;
	Vector3 vec;
	Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		vec = new Vector2 (speed, 0);
		if (d == 0) {
			int r = Random.Range (0, 2);
			d = -1 + 2 * r;
		}
	}
	void OnCollisionEnter2D (Collision2D col){
			d = -d;
	}
	void Update(){
		rb.transform.position += vec * d * Time.deltaTime;
	}
}
