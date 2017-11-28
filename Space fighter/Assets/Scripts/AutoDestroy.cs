using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {

	// Use this for initialization
	private void Start () {
	
		Destroy (gameObject, GetComponent<ParticleSystem> ().duration);
	}
	

}
