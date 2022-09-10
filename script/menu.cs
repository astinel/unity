using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titlemenu : MonoBehaviour {
	public GameObject go;

	public void start(){
		SceneManager.LoadScene (2);
		//gameObject.SetActive (false);
		//go.SetActive (true);
	}
	public void ready(){
		SceneManager.LoadScene (1);
	}
	public void exit(){
		Application.Quit ();
	}
}