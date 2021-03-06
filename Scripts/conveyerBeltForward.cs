using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyerBeltForward : MonoBehaviour {

	public float beltSpeed=5f;

	private GameObject conveyerBelt;

	private GameObject player1;
	private GameObject player2;
	private GameObject player3;
	private GameObject player4;

	private bool p1OnConveyorBelt;
	private bool p2OnConveyorBelt;
	private bool p3OnConveyorBelt;
	private bool p4OnConveyorBelt;

	//GameObject[] players = {player1, player2, player3, player4};

	void Start () {
		player1 = GameObject.Find ("Player");
		player2 = GameObject.Find ("Player2");
		player3 = GameObject.Find ("Player3");
		player4 = GameObject.Find ("Player4");
	}

	// Update is called once per frame
	void Update () {
		if (p1OnConveyorBelt) {
			player1.transform.position = player1.transform.position + new Vector3 (0f, 0f, beltSpeed);
		}
		if (p2OnConveyorBelt) {
			player2.transform.position = player2.transform.position + new Vector3 (0f, 0f, beltSpeed);
		}
		if (p3OnConveyorBelt) {
			player3.transform.position = player3.transform.position + new Vector3 (0f, 0f, beltSpeed);
		}
		if (p4OnConveyorBelt) {
			player4.transform.position = player4.transform.position + new Vector3 (0f, 0f, beltSpeed);
		}


	}

	void OnTriggerEnter(Collider col)
	{
		
		if (col.gameObject.tag == "Player") {
			Debug.Log ("Player is on the Conveyor Belt");
			p1OnConveyorBelt = true;

		}
			
		if (col.gameObject.tag == "Player2") {
			Debug.Log ("Player2 is on the Conveyor Belt");
			p2OnConveyorBelt = true;
		}
			
		if (col.gameObject.tag == "Player3") {
			Debug.Log ("Player3 is on the Conveyor Belt");
			p3OnConveyorBelt = true;
		}
			
		if (col.gameObject.tag == "Player4") {
			Debug.Log ("Player4 is on the Conveyor Belt");
			p4OnConveyorBelt = true;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			Debug.Log ("Player is NOT on the Conveyor Belt");
			p1OnConveyorBelt = false;

		}

		if (col.gameObject.tag == "Player2") {
			Debug.Log ("Player2 is NOT on the Conveyor Belt");
			p2OnConveyorBelt = false;
		}

		if (col.gameObject.tag == "Player3") {
			Debug.Log ("Player3 is NOT on the Conveyor Belt");
			p3OnConveyorBelt = false;
		}

		if (col.gameObject.tag == "Player4") {
			Debug.Log ("Player4 is NOT on the Conveyor Belt");
			p4OnConveyorBelt = false;
		}
	}
}
