using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normal : MonoBehaviour {
	block blo;
	SpriteRenderer spr;

	void Start(){
		spr = GetComponent<SpriteRenderer> ();
		color ();
	}
	void OnEnable(){
		blo = GetComponent<block> ();

		/*if (data.mode == 2)
			blo.hp = information.stage / 5 + 1;*/
	}

	void color(){
		if (blo.hp == 1)
			spr.color = Color.white;
		else if (blo.hp == 2)
			spr.color = Color.red;
		else if (blo.hp == 3)
			spr.color = Color.green;
		else if (blo.hp == 4)
			spr.color = Color.yellow;
		else if (blo.hp == 5)
			spr.color = Color.magenta;
		else if (blo.hp >= 6)
			spr.color = Color.black;
	}
	void OnCollisionEnter2D (Collision2D col){
		color ();
	}
}
