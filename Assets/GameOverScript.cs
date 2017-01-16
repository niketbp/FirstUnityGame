using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	public Text scoreText;
	public int score = UIManagerScript.score;

	// Use this for initialization
	void Start () {
		scoreText.text = "Score: " + score;
		resetGame ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void resetGame(){
		UIManagerScript.score = 0;
		UIManagerScript.lives = UIManagerScript.numLives;
	}
}
