using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass {

	private int perception;
	private int strength;
	private int agility;

	public int Perception{
		get { return perception; }
		set{perception = value;}
	}
	public int Strength{
		get { return strength; }
		set{strength = value;}
	}
	public int Agility{
		get { return agility; }
		set{agility = value;}
	}


}
