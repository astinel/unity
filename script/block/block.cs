using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour {
	public float rate;
	public int hp;

	void OnCollisionEnter2D (Collision2D col)		//충돌시
	{
		if (col.gameObject.layer == 9) {
			int a = col.gameObject.GetComponent<attack> ().atk;

			hp -= a;
		}
		if (hp <= 0) {
			if (Random.Range (0, 100) < rate) {
				game g = GameObject.Find ("Game").GetComponent<game> ();
				g.makeitem (transform.position);
			}
			Destroy (gameObject);
		}
	}
	void OnDisable(){
		information.score++;
		game.blockcount--;
	}
}