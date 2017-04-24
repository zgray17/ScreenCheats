using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class TrapDoorCollision : MonoBehaviour {

	private GameObject trapDoor;
	private GameObject player1;
	private GameObject trapDoorCopy;
	private bool triggered = false;

	public int time = 0;
	public int delay = 60;
	private Vector3 startPos;


	public Vector3 sendPos = new Vector3(0,0,0);

	public int waitTime = 1000;
	// Use this for initialization
	void Start () {
		//trapDoorCopy = Instantiate<GameObject> (trapDoor);
		startPos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if(triggered)
		{
			time++;
			if (time>= delay) 
			{
				saveObject();
				time = 0;
				triggered = false;
			}
		}
	}

	//This script works for all players going on the trap door.
	//Could be a new way to kill a player, have the floor come out from under
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {

			Debug.Log ("Player Entered TrapDoor Area");
			triggered = true;

		}
	}


	//attempting to respawn another trap door after the first one gets destroyed
	void saveObject()
	{
		transform.position = sendPos;
	}

	void loadObject()
	{
		transform.position = startPos;
	}



}