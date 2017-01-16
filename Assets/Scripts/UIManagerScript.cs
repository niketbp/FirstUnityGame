using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour {

	int score = 0;
	public Text scoreText;

	private const int numLives = 1;
	public static int lives = numLives;
	public Text livesText;

	// Use this for initialization
	void Start () {
		livesText.text = "Lives: " + lives;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void incrementScore(){
		score++;
		scoreText.text = "Score: " + score;
	}

	public void checkLives(){
		if (lives == 0) {
			resetLives ();
			loadLevel ("GameOver");
		} else {
			decrementLives ();
			loadLevel("level1");
		}
	}

	public void resetLives(){
		lives = numLives;
		livesText.text = "Lives: " + lives;
	}

	public void decrementLives(){
		--lives;
		livesText.text = "Lives: " + lives;
	}

	void loadLevel(string level){
		Application.LoadLevel (level);
	}
}
