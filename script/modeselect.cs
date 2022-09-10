using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class modeselect : MonoBehaviour {
	public GameObject go;

	public void adventure(){
		//data.mode = 1;
		SceneManager.LoadScene (2);
	}
	public void normal(){
		gameObject.SetActive (false);
		go.SetActive (true);
	}
	public void infinite(){
		//data.mode = 3;
		SceneManager.LoadScene (2);
	}

}
