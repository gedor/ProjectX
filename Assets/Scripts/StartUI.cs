using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartUI : MonoBehaviour {

	private Canvas StartingCanvas;
	public Slider healthBar;
	// Use this for initialization
	void Awake () {
		StartingCanvas = GetComponent<Canvas>();
		StartingCanvas.enabled = true;
		healthBar.gameObject.SetActive(false);

	}
	
	void Update (){
		
		TurnOffStartCanvas ();

		}


	
		
private void TurnOffStartCanvas(){

		if (StartingCanvas.enabled){ 
			if (Input.GetKeyUp (KeyCode.Space)) {
				StartingCanvas.enabled = false ;
				healthBar.gameObject.SetActive (true);
			}
			}
	}
}
