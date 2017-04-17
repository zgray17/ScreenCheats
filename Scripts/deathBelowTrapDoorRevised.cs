using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathBelowTrapDoorRevised : MonoBehaviour {
	private List<GameObject> deadObjects = new List<GameObject>();
	public float beltSpeed=.25f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i <= deadObjects.Count; i++) 
		{
			deathToPlayers (deadObjects[i]);
		}
	}

	void OnTriggerEnter(Collider col)
	{
		deadObjects.Add(col.gameObject);
	}

	void OnTriggerExit(Collider col)
	{
		deadObjects.Remove(col.gameObject);
	}

	void deathToPlayers(GameObject target)
	{
		target.gameObject.GetComponent<MeshRenderer> ().enabled = false;
	}

}
