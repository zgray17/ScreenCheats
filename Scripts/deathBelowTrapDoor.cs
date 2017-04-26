using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathBelowTrapDoor : MonoBehaviour {

	private GameObject player1;
	private GameObject player2;
	private GameObject player3;
	private GameObject player4;


	private bool DeadPlayer = false;
	private bool DeadPlayer2 = false;
	private bool DeadPlayer3 = false;
	private bool DeadPlayer4 = false;

	// Use this for initialization
	void Start () {
		player1 = GameObject.Find ("Player");
		player2 = GameObject.Find ("Player2");
		player3 = GameObject.Find ("Player3");
		player4 = GameObject.Find ("Player4");
	}
	
	// Update is called once per frame
	void Update () {
		if (DeadPlayer) {
			Debug.Log ("Player is dead");
			DeadPlayer = false;
		}
		if (DeadPlayer2) {
			Debug.Log ("Player2 is dead");
			DeadPlayer2 = false;
		}
		if (DeadPlayer3) {
			Debug.Log ("Player3 is dead");
			DeadPlayer3 = false;
		}
		if (DeadPlayer4) {
			Debug.Log ("Player4 is dead");
			DeadPlayer4 = false;
		}

	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			Debug.Log ("Player Entered Ground Area");
			Destroy (player1.gameObject.GetComponent<MeshRenderer>());
			DeadPlayer = true;
		}
		if (col.gameObject.tag == "Player2") {
			Debug.Log ("Player2 Entered Ground Area");
			Destroy (player2.gameObject.GetComponent<MeshRenderer>());
			DeadPlayer2 = true;
		}
		if (col.gameObject.tag == "Player3") {
			Debug.Log ("Player3 Entered Ground Area");
			Destroy (player3.gameObject.GetComponent<MeshRenderer>());
			DeadPlayer3 = true;
		}
		if (col.gameObject.tag == "Player4") {
			Debug.Log ("Player4 Entered Ground Area");
			Destroy (player4.gameObject.GetComponent<MeshRenderer>());
			DeadPlayer4 = true;
		}
	}
}
