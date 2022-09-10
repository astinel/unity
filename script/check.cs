using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class check : MonoBehaviour {
	public static short able;
	public GameObject shortage;

	public void buy(){
		if (able == 1) {
			data.save ();
			for (short c = 0; c < store.cc.Length; c++)
				store.cc [c] = 0;
		} else {
			shortage.SetActive (true);
		}
	}
	public void reset(){
		data.load ();
		SceneManager.LoadScene (1);
	}
	public void back(){
		SceneManager.LoadScene (0);
	}
}
