using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWallScript : MonoBehaviour {

	public int lives = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Ball") {
			Application.LoadLevel ("level1");
			if (lives == 0) {
				gameOver ();
			}
			print ("reached");
		}
	}

	void gameOver(){
		Application.LoadLevel ("GameOver");
	}

}
