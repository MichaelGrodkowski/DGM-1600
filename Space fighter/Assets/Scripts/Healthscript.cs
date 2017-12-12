using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthscript : MonoBehaviour {

	public int health;
	public GameObject explosionEffect;
	public GameObject[] hearts;
	public Animator animator;
	public GameObject Scoreboard;
	public Scoreboard ScoreScript;


	private void Start() {
			ShowHearts ();
			ScoreScript = FindObjectOfType<Scoreboard> ();
		}


			//Colliding of objects does damamge
			void OnCollisionEnter2D (Collision2D myCollider){
		Instantiate (explosionEffect, transform.position, Quaternion.identity);

		health--;

		if (health <= 0) {
			Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
		}

	}

	private bool MePlayer () {
		if (GetComponent<PlayerController> ()) {
			return true;
		} else {
			return false;
		}
	}

			//collision of laser to rigidbodies does damage.
			void OnTriggerEnter2D (Collider2D myCollider) {
		Instantiate (explosionEffect, transform.position, Quaternion.identity);


		health--;

		if (health <= 0) {
			Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
		}
	}






			public void IncrementHealth(int value){
		health += value;
		if (health <= 0) {
			Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
			//if (!MePlayer ()) {
			// ();
			//}
			//if (MePlayer ()) {
			//gameObject.GetComponent<PlayerController> ().levelManager.GetComponent<LevelManager> ().LevelLoad ("GameOver");
			//}
		
			ShowHearts ();
		}
	}

	
	private void ShowHearts(){
		//turn all hearts off
	for (int i = 0; i < hearts.Length; i++) { 
			hearts [i].SetActive (false);
		}
		//turn all hearts on by health.
		for (int i = 0; i < health; i++) {
			hearts [i].SetActive (true);

		}
	
	}
	private void IncrementScore ()
	{
		Scoreboard.GetComponent<Scoreboard> ().IncrementScoreboard (10);

	}
	

}


