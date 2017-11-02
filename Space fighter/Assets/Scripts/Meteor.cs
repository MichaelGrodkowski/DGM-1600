using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {


	public int health; 
	public Sprite[] picture;
	private int count = 0;
	private LevelManager LevelManager;


	public float startingSpin;
	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-startingSpin,startingSpin),ForceMode2D.Impulse); 

	}


	LevelManager = FindObjectOfType<LevelManager> ();
}

 void OnCollisionEnter2D (Collision2D collider)
{

	//Take away 1 health for each impact
	health--;
	count++;

	// If health is < 0 destroy the brick.


	if (health <= 0) {
		Destroy (this.gameObject);
		LevelManager.brickCount--;
		LevelManager.CheckBrickCount ();
	}
	GetComponent<SpriteRenderer>().sprite = picture[count];


}
}

	// Update is called once per frame
	void Update () {
		
	}
}
