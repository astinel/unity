using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stageinfo : MonoBehaviour {
	public static Text info;
	public short delay;
	Color col;
	float time;
	float speed = 1/255f;
	short state;

	void Awake(){
		info = gameObject.GetComponent<Text> ();
		col = info.color;
	}
	void OnEnable () {
		state = 0;
	}
	void Update () {
		time += Time.deltaTime;
		if (state == 0) {
			if (time > delay) {
				state = 1;
				time = 0;
			}
		} else if (state == 1) {
			if (info.color.a <= 0)
				gameObject.SetActive (false);
			col.a -= speed;
			info.color = col;
		}
	}
}
