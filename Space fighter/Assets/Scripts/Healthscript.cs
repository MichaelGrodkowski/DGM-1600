﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthscript : MonoBehaviour {

	public int health;
	public GameObject explosionEffect;

	public void IncrementHealth(int damage){
		health += damage;
		if (health <= 0) {
		    Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
	}
}



}