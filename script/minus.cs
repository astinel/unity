using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minus : MonoBehaviour {
	short limit = 0;

	public void ballminus(){
		if (store.cc [0] > limit) {
			data.ball--;
			store.cc [0]--;
		}
	}
	public void atkminus(){
		if (store.cc [1] > limit) {
			data.atk--;
			store.cc [1]--;
		}
	}
	public void lenminus(){
		if (store.cc [2] > limit) {
			data.len -= store.lenvar;
			store.cc [2]--;
		}
	}
	public void bombminus(){
		if (store.cc [3] > limit) {
			data.fireball.count--;
			store.cc [3]--;
		}
	}
}
