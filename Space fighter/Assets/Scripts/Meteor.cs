using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {


		public int health; 
		public Sprite[] picture;
		public int count = 0;
		public LevelManager LevelManager;
		public float startingSpin;

		void Start()
		{

			GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-startingSpin,startingSpin),ForceMode2D.Impulse); 
		}

		void Update ()
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
