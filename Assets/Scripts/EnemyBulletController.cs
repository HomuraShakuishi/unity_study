//敵の撃つ弾の処理。１つでまとめる方法がわかったらBulletControllerに合流させる
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour {
	public GameObject EnemyBulletPrefab;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (0, -0.3f, 0);

		if (transform.position.y < -5.3f) {
			Destroy (gameObject);
		}
	}
}