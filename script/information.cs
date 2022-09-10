using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class information : MonoBehaviour {
	public static int stage;
	public static int score;
	public Text scoreinfo;
	public Text specialinfo;

	void Update () {
		scoreinfo.text = "점수: " + score;
		specialinfo.text = "특수: " + movepanel.count;
	}
}
