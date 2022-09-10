using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class stageselect : MonoBehaviour {
	public GameObject go;
	public InputField f;
	public Text stage;
	EventSystem eve = null;
	int sta;

	public void input(Text num){
		if (num.text != "")
			sta = int.Parse (stage.text);
		if (sta > 0 && sta < data.stage) {
			information.stage = --sta;
			//data.mode = 2;
			SceneManager.LoadScene (2);
		}
		Start ();
	}
	void Awake(){
		data.load ();
	}
	void Start(){
		f.OnPointerClick (new PointerEventData (eve));
	}
	void Update(){
		stage.text = "최대 스테이지: " + data.stage;
		if (Input.GetKeyDown (KeyCode.Escape)) {
			gameObject.SetActive (false);
			go.SetActive (true);
		}
	}
}
