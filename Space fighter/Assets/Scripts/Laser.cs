using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	// Use this for initialization
	public float Speed;
	public float lifetime;


	void Update ()
	{
		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}
		transform.Translate (Vector3.up * Speed * Time.deltaTime);
	
	}
}
