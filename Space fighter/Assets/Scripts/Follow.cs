using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public Transform objectToFollow;
	public float zOffset;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

			Vector3 myPos = objectToFollow.position;
		// This is for making the camera follow the ship, the z offset is creating a variable
		// the variable gives distance for the camera from the ship
		myPos.z = zOffset;
		gameObject.transform.position = myPos;

	}
}

