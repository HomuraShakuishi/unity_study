using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour {

	public readonly int maxLife = 100; //プレイヤーの体力最大値、あとでここを変えられるようにする
	public int Life;
	public int EnemyATK;
	public bool LoseCheck;

	public GameObject GOB;

	public PlayerController CanShotController;

// Use this for initialization
	void Start () {
		Life = maxLife;//初期状態は体力が最大値
		LoseCheck = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Life <= 0) {
			//Debug.Log ("GameOver");
			GameoverControll();
			LoseCheck = true;


			///playerにenemyオブジェクトをアサイン
			///CanShotBulletを取得し、falseにしたい
			//EnemyController test2 = test.GetComponent<EnemyController> ();
			//test2.CanShotBullet = false;


		}

	}

	void OnTriggerEnter2D (Collider2D hit){
		Debug.Log ("あああ");
		if (hit.CompareTag ("Bullet")) {
			Life -= EnemyATK;
			Debug.Log ("当たったよ");
			//Debug.Log (Life);

		}
	}
	void GameoverControll ()
	{
		if (LoseCheck == true) {

			GOB.SetActive(true);
			CanShotController.CanMove = false;

			//getGOB.Lose ();
			//GameOverCheck.Find("GameOver").GetComponent<GameOverButton> ().Lose ();
			//GameOverButton.Lose ();
			//PlayerController CSC = .Find ("Player").GetComponent<PlayerController> ();
			//CSC.CanMove = false;
		}
	}


}
//やりたいこと
//敵のHPの実装
//複数の敵の実装
//敵(弾)ごとの攻撃力の設定
//ポイントの実装

