﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWallScript : MonoBehaviour {

	public UIManagerScript ui;

//	private const int numLives = 1;
//	public static int lives = numLives;

	// Use this for initialization
	void Start () {
		ui = GameObject.FindWithTag ("UI").GetComponent<UIManagerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Ball") {
			ui.checkLives ();
		}
	}



}
