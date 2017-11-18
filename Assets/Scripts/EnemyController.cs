using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public GameObject enemybullet;
	public float shotspeed;
	private int count = 0;
	//commonMovableplayer commonmovableplayer;
	public bool CanShotBullet;
	public int EnemyLife;
	public int EnemyAttack;

	public bool destory;
	public GameObject explosion;



	// Use this for initialization
	void Start () {
		//CanShotBullet = true;
		destory = false;
	}
	// Update is called once per frame
	void Update () {
		count++;
		//80フレームごとにメソッドを実行
		if (CanShotBullet == true) {
			if (count % 80 == 0) {
				EnemyShot ();
			}
		}
		if (EnemyLife <= 0) {
			destory = true;
		}
		if (destory == true) {
			Explosion ();
		}

	}
	public void EnemyShot(){
		/*GameObject Enebullet =*/ GameObject.Instantiate (enemybullet, transform.position, Quaternion.identity);

		}
	void OnTriggerEnter2D (Collider2D hit){
		Debug.Log ("いいい");
		if (hit.CompareTag ("playerBullet")) {
			
			int pATK = GameObject.Find ("Player").GetComponent<PlayerController> ().playerATK;
			EnemyLife -= pATK;
			//Debug.Log ("的に当たったよ");
		}
	}
	public void Explosion ()
	{	//Debug.Log ("ここまでok");
		Instantiate (explosion,transform.position,transform.rotation);
		Destroy (gameObject);
	}
			
}
//"いいい"から下が出ない

//37行目の処理のやりかた
//オブジェクトをasignしてその中のスクリプトを拾う方法
//初期化してないから？？？