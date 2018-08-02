using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Victory1 : MonoBehaviour {

	//public string Victoryd;
	public string FailD;
	private DialogueManager Dman;
	private GameInfo gi;
	public Canvas VictoryCanvas;
	public Slider healthBar;

	// Use this for initialization
	void Start () {
		Dman = FindObjectOfType<DialogueManager> ();
		VictoryCanvas.enabled = false;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.name == "Player" && GameInfo.Perception > 10 && Input.GetKeyUp (KeyCode.Space))
		{
				//VictoryCanvas.GetComponent<Canvas> ().enabled = true;

				VictoryCanvas.enabled = true;
				healthBar.gameObject.SetActive(false);
			Destroy (other.gameObject.GetComponent<Rigidbody2D> ());
			Destroy (other.gameObject.GetComponent<Animator>());
		} else if (other.gameObject.name == "Player" && GameInfo.Perception<10 && Input.GetKeyUp (KeyCode.Space)) 
				  {
				Dman.showBox (FailD);
			}
			


	}
}
