﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void Levelload (string level01){
		SceneManager.LoadScene (level01);
	}




	public void ExitGame (){
		print("Tried to Exit Application");
		Application.Quit ();
		
 }
}
