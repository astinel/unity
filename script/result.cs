using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class result : MonoBehaviour {

	movepanel mp;

	void Awake(){
		mp = GameObject.Find ("Move Panel").GetComponent<movepanel> ();
	}
	public void resume(){
		gameObject.SetActive (false);
	}
	public void quit(){
		SceneManager.LoadScene (0);
	}
	void OnEnable(){
		Time.timeScale = 0;
	}
	void OnDisable(){
		Time.timeScale = 1;
	}
}
