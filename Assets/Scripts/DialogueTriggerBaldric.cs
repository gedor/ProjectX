using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerBaldric : MonoBehaviour {

	public Dialogue1 dialogue;


	public void TriggerDialogue(){
		FindObjectOfType<DialogueManager1> ().StartDialogue (dialogue);
	}


	void OnTriggerStay2D(Collider2D other){

		if (other.gameObject.name == "Player") {
			if(Input.GetKeyUp(KeyCode.Space)){
				TriggerDialogue();
			}
				
		}
		
	
		
	}
}
