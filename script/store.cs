using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class store : MonoBehaviour {
	public static float lenvar = 0.4f;
	public static short[] cc;
	public Text gold;
	public Text ball;
	public Text atk;
	public Text len;
	public Text fireball;
	public Text total;
	public Text[] pricegold;
	public Text[] count;
	public Text[] sum;
	public int[] price;
	int tot;
	int s;

	void Awake(){
		data.load ();
		cc = new short[count.Length];
		for (short c = 0; c < count.Length; c++)
			pricegold [c].text = price [c] + "G";
	}
	void Update () {
		tot = 0;
		gold.text = "골드: " + data.gold;
		ball.text = "" + data.ball;
		atk.text = "" + data.atk;
		len.text = "" + data.len.ToString ("N1");
		fireball.text = "" + data.fireball.count;
		for (short c = 0; c < count.Length; c++) {
			count [c].text = "X " + cc [c];
			s = price [c] * cc [c];
			sum [c].text = " = " + s + "G";
			tot += s;
		}
		total.text = "" + tot;
		if (tot > data.gold) {
			total.color = Color.red;
			check.able = 0;
		} else {
			total.color = Color.green;
			check.able = 1;
		}
	}
}
