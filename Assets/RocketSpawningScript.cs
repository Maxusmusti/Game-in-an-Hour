using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSpawningScript : MonoBehaviour {
	public GameObject rocket;
	public GameObject deathText;
	public GameObject scoreText;
	public float minWidth;
	public float maxWidth;
	public float shotCooldown;
	float shotTimer;
	// Use this for initialization
	void Start () {
		shotTimer = shotCooldown;
		deathText.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		shotTimer -= Time.deltaTime;
		if (shotTimer <= 0) {
			transform.position = new Vector2 ( Random.Range (minWidth, maxWidth), transform.position.y);
			GameObject rocc = Instantiate (rocket);
			rocc.GetComponent<RocketKillingScript> ().deathText = deathText;
			rocc.GetComponent<RocketKillingScript> ().scoreText = scoreText;
			rocket.transform.position = transform.position;
			shotTimer = shotCooldown;
		}
	}
}
