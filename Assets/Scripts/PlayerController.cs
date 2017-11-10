using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour {
	public GameObject Prefab;
	public static int count;//発射間隔
	int frame;
	// Use this for initialization
	void Start () {
		count = 10;
	}
	
	// Update is called once per frame
	void Update () {
		frame++;

		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 0.1f, 0);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-0.1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, -0.1f, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (0.1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.Space)&&frame%count ==0) {
			//GameObject bulletPrefab = GameObject.Instantiate (Prefab)as GameObject;

			Instantiate(Prefab, transform.position, Quaternion.identity);
		}
	}
}

