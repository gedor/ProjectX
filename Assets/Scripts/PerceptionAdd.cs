using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class PerceptionAdd : MonoBehaviour {

	new Statovipocetni newperc;
	void Awake(){
		newperc = GetComponent<Statovipocetni> ();
	}
	void AddPerception(int amount){
		newperc.Perception += amount;

	}
}
