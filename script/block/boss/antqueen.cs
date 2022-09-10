using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antqueen : MonoBehaviour {
	public GameObject antball;
	public GameObject soliderant;
	public float delay;
	public int actrate;
	public int range;
	Vector3 vec = Vector2.down * 3;
	float time;
	int r;

	void Update () {
		time += Time.deltaTime;
		if (time >= delay) {
			time = 0;
			r = Random.Range (0, actrate);
			if (r == 0) {
				Instantiate (antball, transform.position + vec, Quaternion.identity, transform.parent);
			} else if (r == 1) {
				int x, y;
				Vector3 v;

				x = Random.Range (-range, range + 1);
				y = Random.Range (-range, range + 1);
				v = new Vector2 (x, y + transform.position.y);
				Instantiate (soliderant, v, Quaternion.identity, transform.parent);
				game.blockcount++;
			}
		}
	}
	void OnDisable(){
		game.state = 0;
	}
}