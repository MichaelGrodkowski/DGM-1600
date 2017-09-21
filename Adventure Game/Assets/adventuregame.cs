using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adventuregame : MonoBehaviour {

	public Text textObject; 

	public enum States
	{
	 start, lost, lostwoods, ghost_0, Abandoned_Mansion, Collapsed_Church,
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
	}
	void State_Collapsed_Church()
	{
		textObject.text = "Collapsed Church State";
	}

}
