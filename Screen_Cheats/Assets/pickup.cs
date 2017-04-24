using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {
    public Vector3 storage, location;
    public int respawn;
    public int delay;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(respawn==0)
        {
            transform.position = location;
        }
        if(respawn>0)
        {
            respawn--;
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log(col.gameObject.name);
            transform.position = storage;
            respawn = delay;
        }
    }
}
