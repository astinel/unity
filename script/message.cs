using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message : MonoBehaviour {
	public static float time = 0;
	public short delay;

	void Update(){
		time += Time.deltaTime;
		if (time >= delay) {
			gameObject.SetActive (false);
		}
	}
}