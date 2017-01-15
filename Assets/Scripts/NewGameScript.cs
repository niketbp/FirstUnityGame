using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGameScript : MonoBehaviour {

	public void restart(){
		Application.LoadLevel ("level1");
	}
}
