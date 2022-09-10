using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soliderant : MonoBehaviour {
	public float xspeed;
	public float yspeed;
	public float yrange;
	public int xd;
	public int yd;
	Vector3 x;
	Vector3 y;
	Rigidbody2D rb;
	float posy;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		x = new Vector2 (xspeed, 0);
		y = new Vector2 (0, yspeed);
		if (xd == 0) {
			int r = Random.Range (0, 2);
			yd = xd = -1 + 2 * r;
		}
		posy = transform.position.y;
	}
	void OnCollisionEnter2D (Collision2D col){
		xd = -xd;
		yd = -yd;
	}
	void Update(){
		rb.transform.position += (x * xd + y * yd) * Time.deltaTime;
		if (transform.position.y > posy + yrange || transform.position.y < posy - yrange)
			yd = -yd;
	}
}
