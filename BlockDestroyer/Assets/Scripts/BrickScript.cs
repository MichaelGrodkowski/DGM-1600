using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour {

	public int health; 





	public class Health : MonoBehaviour 
	{
		public const int maxHealth = 3;
		public int currentHealth = maxHealth;

		if (currentHealth <= 0)
		{
				currentHealth = 0;
				Debug.Log("Dead!");

		}	
	}
		// Use this for initialization
	public.class


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
	