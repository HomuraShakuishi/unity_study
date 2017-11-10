using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour {

	public readonly int maxLife = 100; //プレイヤーの体力最大値、あとでここを変えられるようにする
	public int Life;
	public int EnemyATK = 10;//敵の攻撃力　あとでここも(ry


	// Use this for initialization
	void Start () {
		Life = maxLife;//初期状態は体力が最大値

	}
	
	// Update is called once per frame
	void Update () {
		if (Life <= 0) {
			Debug.Log ("GameOver");
		}
	}

	void OntriggerEnter (BoxCollider2D hit){

		if (hit.CompareTag ("Bullet")) {
			Life -= EnemyATK;
			Debug.Log ("当たったよ");
			//Debug.Log (Life);

		}
	}
}
