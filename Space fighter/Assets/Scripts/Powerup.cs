using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {
	//types of upgrades through the enum, for the types of the same file.
	public enum Type {Shield, Plasma, Speed, SuperUltraMegaHyperLaserBeam

	};
	public Type Powertype;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {

		Debug.Log ("We hit a powerup!");
	}

}
