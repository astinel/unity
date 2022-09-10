using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedcheck : MonoBehaviour {
	float x;
	float t;

	void OnCollisionEnter2D (Collision2D col){
		Debug.Log (t);
		t = 0;
	}
	void Update(){
		t += Time.deltaTime;
	}
}
