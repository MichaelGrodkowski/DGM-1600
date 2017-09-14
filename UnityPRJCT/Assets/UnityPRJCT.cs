using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UnityPRJCT: MonoBehaviour {

	public Text textBox;

	private int max = 100;
	private int min = 1;
	private int guess = 50;

	public int counter;

	// Use this for initialization
	void Start () 
	{
		guess = Random.Range (min, max);

		textBox.text = "Welcome to Number UnityPRJCT "
		    + "\n Pick a number in your head"
		    + "\n\nThe highest number you can pick is" + max
			+ "\nThe lowest number you can pick is " + min
			+ "\n\nIs the number higher or lower than "  + guess
			+ "\n Up arrow for higher, down arrow for lower, enter for equal";

		
		print ("Welcome to Number UnityPRJCTc#");
		print ("Pick a number in your head");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess); 
		print ("up arrow for higher, down arrow for lower, enter for equal");
		max = max + 1;


	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			
			min = guess; 
			guess = (max + min) / 2;
			counter--;
			print ("Is the number higher or lower than " + guess);
			textBox.text = "Is the number higher or lower than " + guess;

		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) 
		{
			
			max = guess;
			guess = (max + min) / 2;
			counter--;
			print ("Is the number higher or lower than " + guess);
			textBox.text = "Is the number higher or lower than " + guess;
	
		}
		if (Input.GetKeyDown(KeyCode.Return)) 
		{
			counter--;
			print ("All your base are now belong to us.");
			textBox.text = "All your base are now belong to us.";

		}
	
		if (counter == 0) 
		{
			//counter--;
			//print ("All of your are not belong to me! Naaaooooo");

			if (Input.GetKeyDown (KeyCode.Return)) 
			{
				print ("All your base are now belong to us.");
				textBox.text = "All your base are now belong to us.";
			
			}
			else if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) 
			{
				counter--;
				print ("All of your base are not belong to me! Naaaoooo");
				textBox.text = "All of your base are not belong to me! Naaaoooo";
		
			}
		
		}

	
	}

}