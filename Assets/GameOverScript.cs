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
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
