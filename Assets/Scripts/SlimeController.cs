using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour {

	public Transform ObjectToMove;
	public float MovementSpeed = 5.0f;
	public bool ShouldLoop = true;
	public float WaitAtWayPoint = 1.0f;

	public List<Transform> Waypoints = new List<Transform>();

	private int _waypointIndex = 0;
	private bool _shouldMove = true;
	private Transform _transform;
	private float _moveTimer = 0.0f;

	public float WaitToReload;
	private bool reloading;
	private GameObject thePlayer;


	public bool ShouldMove
	{
		get { 

			return _shouldMove;
		}
		set{ 
			_shouldMove = value;
		}

	}

	void Awake(){
		
	}
	void Update(){
		if (Time.time >= _moveTimer)
		Move ();

		if (reloading) {
			WaitToReload -= Time.deltaTime;
			if (WaitToReload < 0) {
				Application.LoadLevel (Application.loadedLevel);
				thePlayer.SetActive (true);
			}
			}

	}
	private void Move(){
	
		if (Waypoints.Count != 0 && _shouldMove) {
			ObjectToMove.position = Vector3.MoveTowards (ObjectToMove.position, Waypoints [_waypointIndex].position, MovementSpeed * Time.deltaTime);
			//kada dodemo do waypointa
			if (Vector3.Distance (ObjectToMove.position,Waypoints[_waypointIndex].position) <= 0.0f)
				{
					_waypointIndex++;
				_moveTimer = Time.time + WaitAtWayPoint;

				}
				if (_waypointIndex >=Waypoints.Count)
				{
					if (ShouldLoop)
						_waypointIndex = 0;
					else
						_shouldMove = false;
				}

		}
	}
	void OnCollisionEnter2D (Collision2D other){
		/*
		if (GameObject.Find("Player").GetComponent<PlayerMovement>().attacking == false) {
			if (other.gameObject.name == "Player") {
				other.gameObject.SetActive (false);
				reloading = true;
				thePlayer = other.gameObject;
			}
		}
*/	
	}


}
