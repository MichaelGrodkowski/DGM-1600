﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public static int brickCount;

	void Start(){
		brickCount = FindObjectsOfType<BrickScript> ().Length;
		print (brickCount);
	}




	public void Levelload (string level01){
		SceneManager.LoadScene (level01);
	}




	public void ExitGame (){
		print("Tried to Exit Application");
		Application.Quit ();
		
 }
	public void LoadNextLevel (){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void CheckBrickCount () {
		if (brickCount <= 0) {
			LoadNextLevel ();
		}
	}

	}
