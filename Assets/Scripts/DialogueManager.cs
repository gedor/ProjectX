using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public GameObject dBox;

	public Text dText;
	public bool dialogueActive;
	private PlayerMovement pla;
	// Use this for initialization
	void Start () {
		pla = GameObject.Find("Player").GetComponent<PlayerMovement> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (dialogueActive && Input.GetKeyDown(KeyCode.Space)){
			dBox.SetActive(false);
			dialogueActive = false;
			pla.canMove = true;
	}

	}
	public void showBox(string dialogue){

		dBox.SetActive (true);
		dialogueActive = true;
		dText.text = dialogue;
		pla.canMove = false;
	}

}
