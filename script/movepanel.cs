using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movepanel : MonoBehaviour {
	public static GameObject weapon;
	public static GameObject awakenball;
	public static ball bal;
	public static int life;
	public static short count;
	public GameObject special;
	public GameObject ball;		//공 오브젝트
	public GameObject wall;
	public Transform balltr;
	public Text messagetext;
	public float limit;
	public float speed = 0.1f;
	game g;
	Vector3 expand = new Vector2 (store.lenvar, 0);
	Vector3 velocity;
	Vector2 ballspeed = Vector2.one;
	Transform tr;

	void Awake(){
		for (int c = 0; c < 3; c++)		//라이프 개수 만큼 생성
			newball();
	}
	void OnEnable(){
	
	}
	//새로운 공 생성
	public void newball(){
		Instantiate (ball, new Vector2 (11 + wall.transform.localScale.x, -4 + life++), Quaternion.identity, balltr);
	}
	void Start () {
		Vector2 pos = new Vector2 (0, -4);
		tr = wall.transform;

		limit = tr.position.x - tr.localScale.x - transform.localScale.x / 2;
		velocity = new Vector2 (speed, 0);
		transform.position = pos;
		transform.localScale = new Vector2 (3, 0.5f);
	}
	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.layer == 11) {
			int c = col.gameObject.GetComponent<item> ().code;

			message.time = 0;
			if (c == 0) {
				attack atk = awakenball.GetComponent<attack> ();
				if (atk.atk < data.atk) {
					atk.atk++;
					messagetext.text = "공격력\n증가";
				} else {
					messagetext.text = "최대\n공격력"; 
				}
				messagetext.color = Color.black;
			} else if (c == 1) {
				if (life < data.ball - 1) {
					newball ();
					messagetext.text = "새로운 공\n추가";
				} else {
					messagetext.text = "최대\n개수";
				}
				messagetext.color = Color.green;
			} else if (c == 2) {
				if (transform.localScale.x < data.len) {
					transform.localScale += expand;
					messagetext.text = "길이\n증가";
				} else {
					messagetext.text = "최대\n길이";
				}
				limit = tr.position.x - transform.localScale.x / 2;
				messagetext.color = Color.yellow;
			} else if (c == 3) {
				if (count < data.fireball.count) {
					count++;
					messagetext.text = "특수 공\n획득";
				} else {
					messagetext.text = "최대\n개수";
				}
				messagetext.color = Color.red;
			}
			messagetext.gameObject.SetActive (true);
			Destroy (col.gameObject);
		}
	}
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.layer == 9) {
			if (game.state == 1)
				game.state = 2;
		}
	}
	void Update () {
		if (Input.anyKey) {
			if (Input.GetKey (KeyCode.RightArrow)) {
				if (transform.position.x < limit)
					transform.position += velocity;
			} else if (Input.GetKey (KeyCode.LeftArrow)) {
				if (transform.position.x > -limit)
					transform.position -= velocity;
			}
			//기울기
			if (Input.GetKey (KeyCode.A)) {
				transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 30));
			} else if (Input.GetKey (KeyCode.D)) {
				transform.rotation = Quaternion.Euler (new Vector3 (0, 0, -30));
			} else {
				transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
			}
			if (Input.GetKeyDown (KeyCode.B)) {
				newball ();
			}
			//발사
			if (Input.GetKeyDown (KeyCode.Space)) {
				if (awakenball == null) {
					awakenball = balltr.GetChild (--life).gameObject;
					Rigidbody2D rb = awakenball.GetComponent<Rigidbody2D> ();
					//bal.ballstate++;
					awakenball.transform.position = transform.position + Vector3.up;
					rb.velocity = 3 * ballspeed;
				}
			}
		}
		//이동

		/*if (bal.ballstate == 1) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				if (weapon == null) {
					if (count > 0) {
						Vector2 vec = transform.position;
						weapon = Instantiate (special, new Vector2 (vec.x, vec.y + 1), Quaternion.identity);
						count--;
					}
				}
			}
		}else if (bal.ballstate == 0) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				Rigidbody2D rb = bal.gameObject.GetComponent<Rigidbody2D> ();
				bal.ballstate++;
				bal.gameObject.transform.position = transform.position + Vector3.up;
				rb.velocity = 3 * ballspeed;
			}
		}*/
	}
}