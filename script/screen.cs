using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screen : MonoBehaviour {

	void Awake(){
		Time.timeScale = 1;
		Screen.SetResolution (Screen.width, Screen.width / 16 * 9, true);
	}
}
