using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adventuregame : MonoBehaviour {

	public Text textObject; 
	public bool gasoline = false;
	public enum States

	{
	 start, lost, Car_breakdown0, Car_breakdown1, Abandoned_Mansion, Collapsed_Church, Basement_stair_door, Second_floor_stairs, Creaky_side_door, Clerk_office
	};
	public States myState;



	// Use this for initialization
	void Start () {
	
		myState = States.start;
	
	
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.start) {
			State_start ();
		} 

		else if (myState == States.Abandoned_Mansion) { 
			State_Abandoned_Mansion ();
		} 
		else if (myState == States.Collapsed_Church) {
			//State_Collapsed_Church ();
		}
	}

	void State_start(){

		textObject.text = "The Game Has started. Your car broke down by an abandoned estate" +
		"\nThere is an Abandoned Mansion with bricked up windows." +
		"\nThere is a Collapsed Church." +
		"\n \n Press A to go to Abandoned Mansion, press C to go to collapsed Church.";

	
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			myState = States.Abandoned_Mansion;
		}
		else if (Input.GetKeyDown (KeyCode.C)) 
		{
			myState = States.Collapsed_Church;
		}
	}


	void State_Abandoned_Mansion()
	{
		textObject.text = "Abandoned Mansion State";

		textObject.text = "You enter the Mansion, an earie and hollow wind sounds inside the house." +
			"\nA old musky smell comes from the door under the stairwell, leading to the basement." +
			"\nYou can see a faint glow coming from a somewhere on the second floor." +
			"\n \n Press S to go up the staircase. Prss B to go to the basement side door.";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.Basement_stair_door;
		}
		else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.Second_floor_stairs;
		}
		
	}
	void State_Second_floor_stairs()
	{
		textObject.text = "Second Floor State";

		textObject.text = "As you ascend the stairwell, the aged wood creaks under your weight with each step." +
			"\nYou come to the top of the stairs and there is a long hallway stretching to your left and right. You hear a echo of a faint crying coming from somewhere on this floor. " +
			"there is a lit candle at the far end of the hall. There is also a closed door right next to you." +
			"\nYou can see a faint glow coming from a somewhere on the second floor." +
			"\n \n ";
	}








	void State_Collapsed_Church()
	{
		textObject.text = "Collapsed Church State";
	}

}
