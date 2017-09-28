using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adventuregame : MonoBehaviour {

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
		if (myState == States.start) {
			State_start ();
		} 

		else if (myState == States.Abandoned_Mansion) { 
			State_Abandoned_Mansion ();
		} 
		else if (myState == States.Collapsed_Church) {
			State_Collapsed_Church ();
		}
		else (myState == States.Basement_stair_door) {
			States.Basement_stair_door ();
		} 
		else if (myState == States.Second_floor_stairs) {
			States.Second_floor_stairs 
		}

	}

	void State_start()
	{

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

		if (Input.GetKeyDown (KeyCode.B)) 
		{
			myState = States.Basement_stair_door;
		}
		else if (Input.GetKeyDown (KeyCode.S)) 
		{
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
			"\n \nPress I to investigate the crying. Press C to search Closed Door.";
		if (Input.GetKeyDown (KeyCode.I)) 
		{
			myState = States.Investigate_Crying;
		} 
		else if (Input.GetKeyDown (KeyCode.C)) 
		{
			myState = States.Storage_closet;
		}
	}
	void State_Storage_Closet()

	{
		textObject.text = "Storage Closet";

		textObject.text = "Pressing on the closed oak door it silently opens. The room is dark but you find the light switch." +
			"\nThe room is clearly a storage closet, while mostly baren and what little remains is rusted and archaic." +
			"\nYou move back a crumpled tarp and find an old container that has the pungent odor of gasoline." +
			"\n \n Press I to investigate the persistant crying, Press R to return to your car.";
		if (Input.GetKeyDown (KeyCode.I)) 
		{
			myState = States.Investigate_Crying;
		}
		else if (Input.GetKeyDown (KeyCode.R)) 
		{
			myState = States.Car_breakdown1;
		}
	}
	void State_Car_breakdown1()
	{
		textObject.text = "Brokendown Car";

		textObject.text = "Carefully lifting the rusted drum of gasoline you start back towards the stairs." +
		"\nEverything is going smoothly until you reach the bottom of the stairs. When you drop the drum onto the marble floor." +
		"\nA cascading crash echos through the mansion. And a blood curdling scream returns from the top of the stairs. And the windows shake." +
		"\n \n In a sheer terror you kick open the front door and rush the gas drum to your car. Press F to refill your car.";
		if (Input.GetKeyDown (KeyCode.F)) 
		{
			myState = States.Victory;
		}
	}
	void State_Victory()
	{
		textObject.text = "Victory";

		textObject.text = "Dropping the heavy drum by your car you frantically move to get the fuel into your vehicle." +
		"\nAs the fuelpours smoothly into your car the summer's air suddenly becomes chilled. With dread you look towards the mansion." +
		"\nIn the doorway of the house a pale figure stood in the darkened hallway, with eyes like soulless pits." +
		"\n \nWhether she was alive or not you couldn't tell. But your car had enough gas so you got in the car and fled for your life." +
		"\nYou Win.";

	}
	
	void State_Collapsed_Church()


	{
		textObject.text = "Collapsed Church State";
		
		textObject.text = "This church was never grand but the support beams were rotting and a hole in the roof let in dim rays of light onto the chapel floor." +
		"\nLooking around you find two doors, one at the front of the church near the broken alter, and another near the back. Which looks like a wine cellar entrance." +
		"\nThe only other notable features of the church is that there seems to be scratch marks on the closed door by the alter." +
		"\n \nPress the C for cellar. Press A to check alter door";
		if (Input.GetKeyDown (KeyCode.C)) 
		{
			myState = States.Cellar;
		}
		else if (Input.GetKeyDown (KeyCode.A)) 
		{
			myState = States.Clerk_office;
		}
	}
		
	void State_Cellar()

	{
		textObject.text = "Cellar";

		textObject.text = "Pulling back the splintering doors of the cellar a dark stairwell descends." +
			"\nGetting near the bottom of the stairs you see something that looks suspiciously like a human figure hiding in the shadows." +
			"\nThe light coming from above reveals that the pull switch to turn on the light is in the middle of the room..." +
			"\n \nPress the L for turning on the light. Press R to run out the way you came.";
		if (Input.GetKeyDown (KeyCode.L)) 
		{
			myState = States.Cellar_light;
		}
		else if (Input.GetKeyDown (KeyCode.R))
		{
			myState = States.Collapsed_church01;
		}
	}
}









