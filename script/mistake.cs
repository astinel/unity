using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mistake : MonoBehaviour {
	float up = 0.01f;
	float time;

	void Update () {
		time += Time.deltaTime;
		transform.position += new Vector3 (0, up, 0);
		if (transform.position.y > -3) {
			Destroy (gameObject);
		}
	}
}
