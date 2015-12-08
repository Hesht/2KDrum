using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using GameSparks;

public class Score : MonoBehaviour {
	private int score;
	private float pushScore;
	// Use this for initialization
	void Start () {
		if(Player.pushMode)
		{
			pushScore = PlayerPrefs.GetFloat ("pushScore");
			GetComponent<Text>().text = "Score: " + pushScore.ToString ();
			checkIfPushHighscore ();
		}
		else
		{
			score = PlayerPrefs.GetInt ("score");
			GetComponent<Text>().text = "Score: " + score.ToString ();
			checkIfHighscore ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void checkIfPushHighscore()
	{
		GameSparksWebSocket s = new GameSparksWebSocket ();

	}

	void checkIfHighscore()
	{
		int place = 0;
		for(int i = 1 ; i < 7 ; i++)
		{
			if(score > PlayerPrefs.GetInt ("highScore" + i.ToString () + "Score"))
			{
				place = i;
				break;
			}
		}
		if(place > 0)
		{
			for(int i = 6 ; i > place ; i--)
			{
				PlayerPrefs.SetString ("highScore" + i.ToString () + "Name", PlayerPrefs.GetString ("highScore" + (i -1).ToString () + "Name"));
				PlayerPrefs.SetInt ("highScore" + i.ToString () + "Score", PlayerPrefs.GetInt ("highScore" + (i -1).ToString () + "Score"));
			}
			PlayerPrefs.SetString ("highScore" + place.ToString () + "Name", PlayerPrefs.GetString ("name"));
			PlayerPrefs.SetInt ("highScore" + place.ToString () + "Score", PlayerPrefs.GetInt ("score"));
		}
		PlayerPrefs.Save ();
	}
}
