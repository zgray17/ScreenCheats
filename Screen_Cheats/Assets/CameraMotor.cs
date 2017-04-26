using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour {

	private Transform lookAt;
	private Vector3 startOffSet;

	// Use this for initialization
	void Start () {

		lookAt = GameObject.FindGameObjectWithTag ("Player").transform;
		startOffSet = transform.position - lookAt.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = lookAt.position + startOffSet;	
	}
}
