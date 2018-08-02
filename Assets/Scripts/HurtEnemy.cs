using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {

	public int damageToGive;
	public GameObject damageBurst;


	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Enemy" && gameObject.GetComponent<PlayerMovement>().attacking == true) {
			other.gameObject.GetComponent<EnemyHealthManager> ().HurtEnemy (damageToGive);
			Instantiate (damageBurst, transform.position, transform.rotation);
		}
	}
}