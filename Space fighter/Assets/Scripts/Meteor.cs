using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {


		
		public Sprite[] picture;
		public int count = 0;
		public LevelManager LevelManager;
		public float startingSpin;

		void Start()
		{

			GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-startingSpin,startingSpin),ForceMode2D.Impulse); 
		}

	private void OnCollisionEnter2D(Collision2D coll){
		coll.gameObject.GetComponent<Healthscript> ().IncrementHealth (-1);
	
	}

			//GetComponent<SpriteRenderer>().sprite = picture[count];


}

