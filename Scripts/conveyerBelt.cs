using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyerBelt : MonoBehaviour {

	public float beltSpeed;
	private GameObject target;

	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (target) {
			if (target.tag == "Player") {
				target.transform.position = target.transform.position + new Vector3 (0f, 0f, beltSpeed);
			}
		}

	}

	void OnTriggerEnter(Collider col)
	{
		Debug.Log ("test");
		target = col.gameObject;
		Debug.Log (target.name);
	}

	void OnTriggerExit()
	{
		target = null;
	}
}
