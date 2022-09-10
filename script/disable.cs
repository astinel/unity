using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable : MonoBehaviour {
	float time;

	void OnEnable(){
		time = 0;
	}
	void Update () {
		time += Time.deltaTime;
		if (time > 1)
			gameObject.SetActive (false);
	}
}
