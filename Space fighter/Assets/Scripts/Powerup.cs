using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {
	//types of upgrades through the enum, for the types of the same file.
	public enum Type {Shield, Plasma, speed, SuperUltraMegaHyperLaserBeam}
	public Type Powertype;
	public Sprite [] images;

	// Use this for initialization
	void Start () {
		switch (Powertype) {
		case Type.speed:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
		break;
		
		}
	}




	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("We hit a powerup!");


		if (Powertype == Type.speed) {
		}

		case Type.speed:
		default:
			break;
		

		switch (Powertype) {
			case Type.speed
		
			other.GetComponent<PlayerController> ().speed *= 2;
				break;
			case Type.Shield
				break;


		Destroy (this.gameObject);
	}

}
