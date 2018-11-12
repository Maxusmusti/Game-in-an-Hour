using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {
	Rigidbody2D rb;
	public float movementSpeed;
	public float jumpHeight;
	bool canJump;
	void Start() {
		rb = GetComponent<Rigidbody2D> ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			rb.AddForce(new Vector2(-movementSpeed,0));
		}
		if (Input.GetKey(KeyCode.D)) {
			rb.AddForce(new Vector2(movementSpeed,0));
		}
		if (Input.GetKeyDown (KeyCode.W) && canJump) {
			rb.AddForce (new Vector2(0,jumpHeight));
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Platform") {
			canJump = true;
		}
	}
	void OnCollisionExit2D(Collision2D col) {
		if (col.gameObject.tag == "Platform") {
			canJump = false;
		}
	}
}
