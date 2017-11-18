using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LifeBarCTRL : MonoBehaviour {
	GameObject player;
	PlayerLife Lifecomp;
	public Slider Lifeslider;
	public int Life;



	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		Lifecomp = player.GetComponent<PlayerLife> ();

		Lifeslider = GameObject.Find ("Slider").GetComponent<Slider> ();
		Life = 100;
		Lifeslider.value = 0;
		Lifeslider.value = Life;

		}
	
	// Update is called once per frame
	void Update () {
		int PyLife = Lifecomp.Life;
		Lifeslider.value = PyLife;
		}
}
