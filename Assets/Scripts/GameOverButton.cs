using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverButton : MonoBehaviour {
	GameObject GameOver;

	// Use this for initialization
	void  Start () {
		//transform.GetComponent<Image>.enabled = false;
		gameObject.SetActive (false);


	}
	
	// Update is called once per frame
	public void Lose () {
		//gameObject.GetComponent<Text>().enabled = true;


		}
	public void PushGameoverButton(){
		SceneManager.LoadScene ("Titlescene");
	}

}

//非表示
//体力が0になる
//表示
//UIボタンでタイトルへ戻るがでる
//押すとタイトルシーンへ移動
//非表示


//わからないこと
//ゲーム開始時点で非表示のオブジェクト(ボタン)を任意タイミングで表示する方法


//GameoverスクリプトでLose メソッドを書いてそこでオブジェクトを有効化する?
//→非表示オブジェクトについているスクリプトは無効化されている。どうやって有効化する？
//SetActiveでfalseにしたオブジェクトを外部からtrueにする　オブジェクトを変数として保持しておく