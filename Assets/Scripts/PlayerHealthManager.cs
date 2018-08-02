using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

	public int playerMaxHealth;
	public int playerCurrentHealth;
	public Canvas GameOverCanvas;
	// Use this for initialization
	void Start () {
		playerCurrentHealth = playerMaxHealth;
		GameOverCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerCurrentHealth <= 0) {
			gameObject.SetActive (false);
			GameOverCanvas.enabled = true;
		
		}
			
	}
	public void HurtPlayer(int damageToGive){
		playerCurrentHealth -= damageToGive;
	}
	public void SetMaxHealth(){
		playerCurrentHealth = playerMaxHealth;
	}
}
