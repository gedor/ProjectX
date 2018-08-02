using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo {

	public static void SaveAllInfo(){
	
		PlayerPrefs.SetInt ("PlayerPerception", GameInfo.Perception);
		PlayerPrefs.SetInt ("PlayerStrength", GameInfo.Strength);
		PlayerPrefs.SetInt ("PlayerAgility", GameInfo.Agility);
	}
}
