using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour {

	public UIManagerScript ui;

	// Use this for initialization
	void Start () {
		ui = GameObject.FindWithTag ("UI").GetComponent<UIManagerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Ball") {
			Destroy (gameObject);
		}
		ui.incrementScore ();
	}
}
