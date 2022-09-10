using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
	public short ballstate = -1;
	Vector3 scale = Vector2.one;

	void Start(){
		transform.localScale = scale / 2;
	}
}