using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaldricVictoryDialogue : MonoBehaviour {
	
	public string dialogue;
	private DialogueManager Dman;
	public bool talkToBal;
	// Use this for initialization
	void Start () {
		Dman = FindObjectOfType<DialogueManager> ();
		talkToBal = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.name == "Player")
		{
			if(Input.GetKeyUp(KeyCode.Space))
			{
				Dman.showBox(dialogue);
				talkToBal = true;
			}
		}
	}

}
