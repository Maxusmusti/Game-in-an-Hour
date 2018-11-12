using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float movementspeed;
	float initSpeed;
	void Start() {
		initSpeed = movementspeed;
	}
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0,-movementspeed);
		if (Input.GetKey(KeyCode.Space)) {
			movementspeed = initSpeed * 0.25f;
		} else {
			movementspeed = initSpeed;
		}
	}
}
