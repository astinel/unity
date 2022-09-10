using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour {
	SpriteRenderer spr;
	Color col;
	float speed = 1/255f;

	void Start () {
		spr = GetComponent<SpriteRenderer> ();
		col = spr.color;
	}
	void Update () {
		if (spr.color.a <= 0)
			Destroy (gameObject);
		col.a -= speed;
		spr.color = col;
	}
}