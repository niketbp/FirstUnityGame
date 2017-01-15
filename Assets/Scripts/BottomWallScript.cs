using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWallScript : MonoBehaviour {

	private const int numLives = 1;
	public static int lives = numLives;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Ball") {
			if (lives == 0) {
				lives = numLives;
				gameOver ();
			} 
			else {
				--lives;
				Application.LoadLevel ("level1");
			}
		}
	}

	void gameOver(){
		Application.LoadLevel ("GameOver");
	}

}
