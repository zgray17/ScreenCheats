using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyerBeltRevised : MonoBehaviour {
	private List<GameObject> beltObjects = new List<GameObject>();
	public float beltSpeed=.25f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i <= beltObjects.Count; i++) 
		{
			beltObjects[i].transform.position = beltObjects[i].transform.position + new Vector3 (0f, 0f, beltSpeed);
		}
	}

	void OnTriggerEnter(Collider col)
	{
		beltObjects.Add(col.gameObject);
	}

	void OnTriggerExit(Collider col)
	{
		beltObjects.Remove(col.gameObject);
	}
}
