using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plus : MonoBehaviour {
	short limit = 9;

	public void ballplus(){
		if (store.cc [0] < limit) {
			data.ball++;
			store.cc [0]++;
		}
	}
	public void atkplus(){
		if (store.cc [1] < limit) {
			data.atk++;
			store.cc [1]++;
		}
	}
	public void lenplus(){
		if (store.cc [2] < limit) {
			data.len += store.lenvar;
			store.cc [2]++;
		}
	}
	public void bombplus(){
		if (store.cc [3] < limit) {
			data.fireball.count++;
			store.cc [3]++;
		}
	}
}
