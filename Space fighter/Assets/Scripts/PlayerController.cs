using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	



	void Start () {
		rig = GetComponent<Rigidbody>();
		transform.position 

	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) { transform.position

		}
		if (Input.GetKeyDown (KeyCode.A)) {
		
		}
		if (Input.GetKeyDown (KeyCode.S)) {
		
		}
		if (Input.GetKeyDown (KeyCode.D)) {
		
		}

		//check for button push
		// print something out
		// move our player.
		//down
		//left
		//right


	}
}

public Text textObject; 
public bool gasoline = false;
public enum States

{
	start, lost, Car_breakdown0, Car_breakdown1, Abandoned_Mansion, Collapsed_Church, Basement_stair_door, Second_floor_stairs, Creaky_side_door, Clerk_office, Investigate_Crying, Storage_closet,
	Candle_lit_door, Witch_room, Ignore_crying, Cellar, Victory, Cellar_light, Collapsed_church01,
};
public States myState;



// Use this for initialization
void Start () {

	myState = States.start;


}

// Update is called once per frame
void Update () {




