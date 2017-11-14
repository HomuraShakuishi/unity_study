using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public GameObject enemybullet;
	public float shotspeed;
	private int count = 0;
	commonMovableplayer commonmovableplayer;


	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		count++;
		//80フレームごとにメソッドを実行
		if (count % 80 == 0) {
			// TODO: オーバーフロー防止のため、count = 0をしよう！
			EnemyShot ();
		}

	}
	public void EnemyShot(){
		GameObject Enebullet = Instantiate (enemybullet, transform.position, Quaternion.identity)as GameObject;

		}

	}



