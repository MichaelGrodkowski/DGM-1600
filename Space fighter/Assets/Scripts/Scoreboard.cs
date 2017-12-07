using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {

	public int score;
	public Text display;
	public Text HighscoreDisplay;

	// Use this for initialization
	void Start () {
		score = 0;
		if (display != null) {
			display.text = score.ToString ();

		}
		if (HighscoreDisplay != null)
			HighscoreDisplay.text = GetScore ().ToString ();
	}
	
	// Update is called once per frame
	public void IncrementScoreboard(int value){
		score += value;
		display.text = score.ToString();
	
	}



	//Check Previous Score
	public void SaveScore(){
		int oldScore = GetScore ();


		if(score > oldScore)
			
		PlayerPrefs.SetInt ("HighScore", score);
	}
	//if new score is higher than the previous score
	public int GetScore(){
		return PlayerPrefs.GetInt ("HighScore");
	}
	public void OnDisable (){
		SaveScore ();
	}
}

