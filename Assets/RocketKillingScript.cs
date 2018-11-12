using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RocketKillingScript : MonoBehaviour {
	public GameObject deathText;
	public GameObject scoreText;
	static int score = 0;
	public static bool dead;

	void Start() {
		dead = false;
	}
	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player" && !dead) {
			Destroy (col.gameObject);
			StartCoroutine (Reset());

		}
	}

	void Update() {
		if (transform.position.y < 0) {
			if (!dead) {
				score++;
				scoreText.GetComponent<Text> ().text = score.ToString ();
			}

			Destroy (gameObject);
		}
	}

	IEnumerator Reset() {
		dead = true;
		score = 0;
		deathText.SetActive (true);
		yield return new WaitForSeconds(2.0f);
		SceneManager.LoadScene ("MainScene");
	}
}
