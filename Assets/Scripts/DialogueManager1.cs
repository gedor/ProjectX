using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager1 : MonoBehaviour {

	public Text  nameText;
	public Text dialogueText;
	private Queue<string> sentences;
	Dialogue1 dia;
	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
	}
	public void StartDialogue(Dialogue1 dialogue){
	
		nameText.text = dia.name;
		sentences.Clear ();
		foreach (string sentence in dia.sentences) 
		{
			sentences.Enqueue(sentence);

		}
		DisplayNextSentence ();
	}
	public void DisplayNextSentence(){
		if (sentences.Count == 0) {
			EndDialogue ();
			return;
		}
		string sentence = sentences.Dequeue ();
		dialogueText.text = sentence;
	}
	void EndDialogue(){
	
	}
}
