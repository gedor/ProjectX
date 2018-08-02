using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreatePlayer : MonoBehaviour {

	private BasePlayerClass newPlayer;

	public Text perceptionText;
	public Text strengthText;
	public Text agilityText;

	private int PointsToSpend = 0;
	public Text pointsText;

	public BaseClass PlayerClass
	{
		get {return PlayerClass;}
		set{PlayerClass = value;}

	}
	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayerClass();
		UpdateUI ();
	}
	public void CreateNewPlayer(){
	
		GameInfo.Perception = newPlayer.Perception;
		GameInfo.Strength = newPlayer.Strength;
		GameInfo.Agility = newPlayer.Agility;
		SaveInfo.SaveAllInfo ();
		SceneManager.LoadScene ("Main");
	}

	public void SetRogueClass(){
		PointsToSpend = 5;
		newPlayer.PlayerClass = new BaseRogueClass();
		newPlayer.Perception = newPlayer.PlayerClass.Perception;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Agility = newPlayer.PlayerClass.Agility;
		UpdateUI ();
	}
	public void SetWarriorClass(){
		PointsToSpend = 5;
		newPlayer.PlayerClass = new BaseWarriorClass();
		newPlayer.Perception = newPlayer.PlayerClass.Perception;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Agility = newPlayer.PlayerClass.Agility;
		UpdateUI ();
	}

	void UpdateUI()
	{
		perceptionText.text = newPlayer.Perception.ToString ();
		strengthText.text = newPlayer.Strength.ToString ();
		agilityText.text = newPlayer.Agility.ToString ();
		pointsText.text = PointsToSpend.ToString ();
	}
	public void SetPerception(int amount){
	
		if (newPlayer.PlayerClass != null) {
			if (amount > 0 && PointsToSpend > 0) {
				newPlayer.Perception += amount;
				PointsToSpend -= 1;
				UpdateUI ();
				Debug.Log ("Points:");
		
			} else if (amount < 0 && newPlayer.Perception > newPlayer.PlayerClass.Perception) {
				newPlayer.Perception += amount;
				PointsToSpend += 1;
				UpdateUI ();
			}
		}
	}
	public void SetStrength(int amount){

		if (newPlayer.PlayerClass != null) {
			if (amount > 0 && PointsToSpend > 0) {
				newPlayer.Strength += amount;
				PointsToSpend -= 1;
				UpdateUI ();

			} else if (amount < 0 && newPlayer.Strength > newPlayer.PlayerClass.Strength) {
				newPlayer.Strength += amount;
				PointsToSpend += 1;
				UpdateUI ();
			}
		}
	}
	public void SetAgility(int amount){

		if (newPlayer.PlayerClass != null) {
			if (amount > 0 && PointsToSpend > 0) {
				newPlayer.Agility += amount;
				PointsToSpend -= 1;
				UpdateUI ();

			} else if (amount < 0 && newPlayer.Agility > newPlayer.PlayerClass.Agility) {
				newPlayer.Agility += amount;
				PointsToSpend += 1;
				UpdateUI ();
			}
		}
	}
	//treba create new player
}
