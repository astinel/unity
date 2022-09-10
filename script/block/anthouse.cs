using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anthouse : MonoBehaviour {
	public GameObject ant;
	public float delay;
	float time;

	void Update () {
		time += Time.deltaTime;
		if (time > delay) {
			Instantiate (ant, transform.position, Quaternion.identity, transform.parent);
			game.blockcount++;
			time = 0;
		}
	}
	void OnDisable(){
		//game.blockcount = 0;
	}
}
