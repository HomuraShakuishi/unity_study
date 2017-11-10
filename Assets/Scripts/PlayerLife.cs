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
		// 別にUpdateでやる必要はない
		// だって、Lifeが0になるのは弾が当たった瞬間だから。
		if (Life <= 0) {
			Debug.Log ("GameOver");
		}
	}

	void OnTriggerEnter2D(Collider2D other) {

		// TODO: 敵の弾と自分の弾を識別する
		if (other.tag == "Bullet") {
			Life -= EnemyATK;
			Debug.Log ("当たったよ");
			//Debug.Log (Life);
		}
	}
}
