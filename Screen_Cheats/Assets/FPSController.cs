using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour {

	public float speed = 15f; // speed which the character turns at
	public float turnSpeed = 5f; // speed at which character turns
	public float sensitivity = 10f; // how sensitive the controlls will be
	public float invertVertical = 1f; // inverts only looking controlls unnecessary because there is a check button in the unity engine editor.
	public float invertAllControls = 1f; // inverts everything
	public float speedBoost = 1f; // can also be used for inverting controlls for movement not looking
	public float verticalVelocity; //variable which will be final force added to vector 3
	public float gravity = 4f; // this is the gravity exerted on the character
	public float jumpForce = 10f; // this is the upward force exerted on the character, this should be the modifier for power ups


	CharacterController player;

	public GameObject eyes;

	float moveFB; //move forward backward
	float moveLR; //move right left

	float rotX;
	float rotY;

	// Use this for initialization
	void Start () {

		player = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (player.isGrounded) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				verticalVelocity = jumpForce;
			} else {
				verticalVelocity -= gravity;
			}
			Vector3 movementJump = new Vector3 (0, verticalVelocity, 0);
		}
        
        else
        {
            verticalVelocity -= gravity;
        }
        

        moveFB = Input.GetAxis ("Vertical") * speed * speedBoost;
		moveLR = Input.GetAxis ("Horizontal") * speed * speedBoost;

		rotX = Input.GetAxis ("Mouse X") * sensitivity;
		rotY = Input.GetAxis ("Mouse Y") * sensitivity;

		Vector3 movement = new Vector3 (invertAllControls * moveLR, verticalVelocity, invertAllControls * moveFB);
		transform.Rotate (0, invertAllControls * rotX, 0);
		eyes.transform.Rotate(invertAllControls * (invertVertical)*rotY, 0, 0); //invertVertical is for a power up to allow the controlls to be inverted for 

		movement = transform.rotation * movement;
		player.Move (movement * Time.deltaTime);

	}
}
