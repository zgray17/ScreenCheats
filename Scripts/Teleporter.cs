using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {
	private List<GameObject> teleportedObjects = new List<GameObject>();

	public GameObject teleportedPad;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i <= teleportedObjects.Count; i++) 
		{
			teleportedObjects [i].transform.position = teleportedPad.transform.position;

		}
	}

	void OnTriggerEnter(Collider col)
	{
		teleportedObjects.Add(col.gameObject);
	}

	void OnTriggerExit(Collider col)
	{
		teleportedObjects.Remove(col.gameObject);
	}
}
