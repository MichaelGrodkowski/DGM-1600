using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour {

	public int health; 
	public Sprite[] picture;
	private int count = 0;

	void OnCollisionEnter2D (Collision2D collider)
	{

		//Take away 1 health for each impact
		health--;
		count++;

		// If health is < 0 destroy the brick.
	

		if (health <= 0) {
			Destroy (this.gameObject);
		}
		GetComponent<SpriteRenderer>().sprite = picture[count];

	}
}