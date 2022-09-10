using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadzone : MonoBehaviour {
	public GameObject miss;
	public Transform can;

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.layer == 9) {
			Vector2 vec = transform.position;
			Vector2 ins = new Vector2 (vec.x, vec.y + 1);
			Instantiate (miss, ins, Quaternion.identity, can);
			game.state = -1;
			if (movepanel.life == 0)
				game.state = 0;
		}
		Destroy (col.gameObject);
	}
}