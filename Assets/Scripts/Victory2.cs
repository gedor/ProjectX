using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Victory2 : MonoBehaviour {

	//public string Victoryd;

	private DialogueManager Dman;
	private GameInfo gi;
	public Canvas VictoryCanvas;
	public Slider healthBar;
	public string dialogue;
	public GameObject Player;
	private BaldricVictoryDialogue baldric;

	// Use this for initialization
	void Start () {
		Dman = FindObjectOfType<DialogueManager> ();
		VictoryCanvas.enabled = false;
		baldric = FindObjectOfType<BaldricVictoryDialogue>();

	}

	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.name == "Player" )
		{
			if (baldric.talkToBal == false && Input.GetKeyUp (KeyCode.Space)) {
			Dman.showBox (dialogue);

		}
			if (other.gameObject.name == "Player" && baldric.talkToBal == true &&Input.GetKeyUp (KeyCode.Space)){

				VictoryCanvas.enabled = true;
				healthBar.gameObject.SetActive (false);
				Destroy (Player.gameObject.GetComponent<Rigidbody2D> ());
				Destroy (Player.gameObject.GetComponent<Animator> ());
			}
			
	}
}
	// Update is called once per frame
	void Update () {
		
	}


	}

	

