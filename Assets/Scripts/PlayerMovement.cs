using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	private Rigidbody2D rbody;
	private Animator anim;

	public bool attacking;
	public float attackingTime;
	private float attackTimeCounter;


	public bool canMove;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		canMove = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (canMove == false) {
			rbody.velocity = Vector2.zero;
			return;
		}

		//if (!attacking) {
			Vector2 movement_vector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

			if (movement_vector != Vector2.zero) {
				anim.SetBool ("IsWalking", true);
				anim.SetFloat ("InputX", movement_vector.x);
				anim.SetFloat ("InputY", movement_vector.y);
			} else {
				anim.SetBool ("IsWalking", false);
			}
		

			rbody.MovePosition (rbody.position + movement_vector * Time.deltaTime);

			if (Input.GetKeyDown (KeyCode.E)) {
				attackTimeCounter = attackingTime;
				attacking = true;
				rbody.velocity = Vector2.zero;
				anim.SetBool ("IsAttacking", true);

			}

		
		//}	
		if (attackTimeCounter > 0) {
			attackTimeCounter -= Time.deltaTime;
		}
		if (attackTimeCounter <= 0) {
			attacking = false;
			anim.SetBool ("IsAttacking", false);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (attacking == true) {
			if (other.gameObject.tag == "Enemy") {
				Destroy (other.gameObject);
			}
		}
	}

}
