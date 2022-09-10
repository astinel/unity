using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour {
	public static int blockcount;
	public static short state;		//게임 상태
	public GameObject movepanel;
	public GameObject infinite;
	public GameObject inactiveblock;
	public GameObject result;
	public GameObject[]itemgo;
	public Text info;
	public Transform background;
	public Transform stage;		//전체 스테이지 오브젝트
	public Transform balltr;		//공 부모
	public int delay;
	public int itemc;//개별 스테이지 트랜스폼
	Transform tr;
	Vector3 down = new Vector2 (0, -1);
	movepanel mp;
	float time;
	int gain;
	public int go_stage;
	public int mode;
	//public short mode;

	public void makeitem(Vector2 pos){
		int ran = Random.Range (0, itemc);

		GameObject go = Instantiate (itemgo [ran], pos, Quaternion.identity);
		go.AddComponent <item> ().code = ran;
	}
	//게임 시작시 한번 실행
	void Awake () {
		data.load ();
		reset ();
		mp = movepanel.GetComponent<movepanel> ();
	}
	//초기화
	void reset(){
		Time.timeScale = 1;
		information.score = 0;
		state = 1;

		/*if (data.mode == 3) {
			short max = 81;

			state = 0;
			information.stage = 0;
			infinite.SetActive (true);
			blockcount = 36;
			for (int b = blockcount; b < max; b++) {
				infinite.transform.GetChild (blockcount).parent = inactiveblock.transform;
			} 
		}*/
	}
	//시작
	void Start() {
		stagesetting ();
	}
	//스테이지
	void stagesetting(){
		int sta;
		int lev;

		sta = data.stage / 5;
		lev = data.stage % 5;

		tr = stage.GetChild (sta).GetChild (lev);
		tr.gameObject.SetActive (true);
		blockcount = tr.childCount;
		background.GetChild (sta).gameObject.SetActive (true);
		info.text = tr.parent.name + " - " + tr.name;
		info.gameObject.SetActive (true);
		//blockcount = 1;
	}
	void newblock(){
		Transform child;
		Transform tr;
		GameObject go;
		int[] ran;
		int[] hp;
		short min = -4;
		short max = 5;
		short posy = 8;
		int bc;
		int cc;
		int rhp = ++information.stage;

		state = 0;
		child = infinite.transform;
		cc = child.childCount;
		gain += information.stage;

		for (short a = 0; a < cc; a++) {
			if (child.GetChild (a).gameObject.activeSelf == false) {
				child.GetChild (a).parent = inactiveblock.transform;
				a--;
				cc--;
			}
		}
		if (child.GetChild (0).position.y == 0) {
			end ();
		}
		for (short a = 0; a < blockcount; a++) {
			child.GetChild (a).transform.position += down;
		}
		for (bc = 1; bc * bc < information.stage; bc++)
			if (bc == 9)
				break;
		blockcount += (short)bc;
		ran = new int[bc];
		hp = new int[bc];
		for (short i = 0; i < bc; i++) {
			ran [i] = Random.Range (min, max) * 2;
			for (short c = 0; c < i; c++) {
				if (ran [i] == ran [c]) {
					i--;
					break;
				}
			}
		}
		for (int i = bc - 1; i >= 0; i--) {
			hp [i] = Random.Range (0, rhp / bc--) + 1;
			if (i == 0)
				hp [0] = rhp;
			rhp -= hp [i];
		}
		for (short i = 0; i < ran.Length; i++) {
			tr = inactiveblock.transform.GetChild (0);
			go = tr.gameObject;
			tr.position = new Vector2 (ran [i], posy);
			tr.parent = infinite.transform;
			go.GetComponent<block> ().hp = hp [i];
			go.SetActive (true);
		}
	}
	void clear(){
		mp.newball ();
		Start ();
	}
	void end (){
		state = -2;
		result.SetActive (true);
	}
	void Update(){
		if(Input.anyKey){
			if (Input.GetKeyDown (KeyCode.Return)) {
				if (Time.timeScale == 0) {
					mp.enabled = true;
					result.SetActive (true);
				} else {
					mp.enabled = false;
					result.SetActive (false);
				}
			}
		}
		if (blockcount == 0) {
			Debug.Log ("끝");
		} else if (state == 0)
			result.SetActive (true);
		/*if (data.mode == 3) {
			if (state == 0) {
				time += Time.deltaTime;
				if (time >= delay) {
					time = 0;
					state = 1;
				}
			} else if (state == 2) {
				state = 0;
				newblock ();
			}
		}*/
		//time += Time.deltaTime;
		//if (state == -1)
			//play ();
	}
}