//実験的に動くオブジェクトの一般的なコードをまとめてみたスクリプト
//使い方を覚えるまでは使わない。たぶん短く出来ると思う
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commonMovableplayer : MonoBehaviour {

	public float speed;
	public float shotDelay;
	public GameObject bullet;


	public void shot(Transform origin){
		Instantiate (bullet, origin.position, origin.rotation);
	}

	public void move(Vector2 direcrion){
		GetComponent<Rigidbody2D> ().velocity = direcrion * speed;
	}
}
