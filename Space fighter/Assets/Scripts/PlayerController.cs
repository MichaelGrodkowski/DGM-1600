﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public Transform shotPos;
	public GameObject projectile;
	public float speed;       
	public float shotForce;
	public ParticleSystem Particles;
	public float thrust;


	//Floating point variable to store the player's movement speed.

	public Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.


	void Start () {
	}
	void Update () {

		//if (Input.GetKey (KeyCode.W))
			//Particles.Emit (1);
		//if (Input.GetKey (KeyCode.A))
			//Particles.Emit (1);
		//if (Input.GetKey (KeyCode.S))
			//Particles.Emit (1);
		if (Input.GetKey (KeyCode.Space))
			Particles.Emit (1);
		

			//if (Input.GetKey(KeyCode.A))
			//{
				//transform.position += Vector3.left * speed * Time.deltaTime;
			//}
			//if (Input.GetKey(KeyCode.D))
			//{
				//transform.position += Vector3.right * speed * Time.deltaTime;
			//}
			//if (Input.GetKey(KeyCode.W))
			//{
				//transform.position += Vector3.up * speed * Time.deltaTime;
			//}
			//if (Input.GetKey(KeyCode.S))
			//{
				//transform.position += Vector3.down * speed * Time.deltaTime;
			//}

		Vector3 POS = Camera.main.WorldToScreenPoint (transform.position);
		Vector3 dir = Input.mousePosition - POS;
		float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg - 90;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);




		if(Input.GetButtonUp("Fire1"))
		{
			GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
			//shot.AddForce(shotPos.forward * shotForce);
		}

		}
	void FixedUpdate () {
		if (Input.GetKey ("space")) {
			rb2d.AddForce (transform.up * thrust);
		}
}
}



