using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour {

	public static int score = 0;
	public Text scoreText;

	public static int numLives = 2;
	public static int lives = numLives;
	public Text livesText;

	// Use this for initialization
	void Start () {
		livesText.text = "Lives: " + lives;
		scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void incrementScore(){
		score++;
		scoreText.text = "Score: " + score;
	}

	public void checkLives(){
		if (lives == 1) {
			loadLevel ("GameOver");
		} else {
			decrementLives ();
			loadLevel("level1");
		}
	}

	public void decrementLives(){
		--lives;
		livesText.text = "Lives: " + lives;
	}

	void loadLevel(string level){
		Application.LoadLevel (level);
	}
}
