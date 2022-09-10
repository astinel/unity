using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour {
	movepanel mp;

	void Awake(){
		mp = GameObject.Find ("Move Panel").GetComponent<movepanel> ();
	}
	void OnEnable(){
		Time.timeScale = 0;
		mp.enabled = false;
	}
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			SceneManager.LoadScene (0);
		else if (Input.GetKeyDown (KeyCode.Return)) {
			if (game.state != -2) {
				Time.timeScale = 1;
				mp.enabled = true;
				gameObject.SetActive (false);
			}
		} else if (Input.GetKeyDown (KeyCode.Space)) {
			if (game.state == -2) 
				SceneManager.LoadScene (1);
		}
	}
}