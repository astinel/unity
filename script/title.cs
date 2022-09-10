using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour {
	public GameObject ball;
	public Transform block;
	Vector2 vec;
	float x,y;
	int xmax = 30;
	int ymin = -19;
	int vel = 3;

	void Awake(){
		data.load ();
		//data.mode = 0;
		x = Random.Range (-xmax, xmax);
		y = Random.Range (ymin, 0);
		vec = new Vector2 (x, y);
		GameObject go = Instantiate (ball, vec, Quaternion.identity);
		Rigidbody2D rb = go.GetComponent<Rigidbody2D> ();
		x = Random.Range (0, vel);
		y = Mathf.Sqrt (vel * vel - x * x);
		vec = new Vector2 (x, y);
		rb.velocity = vec;
	}
}