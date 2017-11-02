using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour {

	public GameObject paddle;
	private bool playing = false;
	private Vector3 paddleToBallVector; // distance from ball to paddle.
	private Rigidbody2D rigid;

	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
		rigid = this.GetComponent<Rigidbody2D> ();
		print (rigid);
	}
	

	void Update () { 

		if (!playing) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
			// If push start button
			if (Input.GetMouseButtonDown (0)) {
				// Ball goes flying off of the paddle. 
				rigid.velocity = new Vector2 (6,28);
				// Playing needs to be set to true, playing = true;
				playing = true;



				print ("pushed mouse");
			}
				
		
		
		}

	
		
	}
}

