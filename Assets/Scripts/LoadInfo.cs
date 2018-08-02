using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInfo {


	public static void LoadAllInfo(){

		GameInfo.Perception = PlayerPrefs.GetInt ("PlayerPerception");
		GameInfo.Strength = PlayerPrefs.GetInt ("PlayerStrength");
		GameInfo.Agility = PlayerPrefs.GetInt ("PlayerAgility");


	}
}
