using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct weapon{
	public int count;
	public int atk;
}

public class data : MonoBehaviour{
	public static float len;
	public static int stage;
	public static int gold;
	public static int ball;
	public static int atk;
	//public static short mode = 0;
	public static weapon fireball;

	public static void load(){
		len = PlayerPrefs.GetFloat ("len", 3);
		gold = PlayerPrefs.GetInt ("gold");
		ball = PlayerPrefs.GetInt ("ball", 3);
		atk = PlayerPrefs.GetInt ("atk", 1);
		fireball.count = PlayerPrefs.GetInt ("fireball.count");
		fireball.atk = PlayerPrefs.GetInt ("fireball.atk", 1);
	}
	public static void save(){
		PlayerPrefs.SetFloat ("len", len);
		PlayerPrefs.SetInt ("gold", gold);
		PlayerPrefs.SetInt ("ball", ball);
		PlayerPrefs.SetInt ("atk", atk);
		PlayerPrefs.SetInt ("stage", stage);
		PlayerPrefs.SetInt ("fireball.count", fireball.count);
		PlayerPrefs.SetInt ("fireball.atk", fireball.atk);
		PlayerPrefs.Save ();
	}
}
