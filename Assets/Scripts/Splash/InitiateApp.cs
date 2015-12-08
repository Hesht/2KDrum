using UnityEngine;
using System.Collections;

public class InitiateApp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(string.IsNullOrEmpty (PlayerPrefs.GetString("highScore1Name")))
		{
			PlayerPrefs.SetString ("highScore1Name", "Billy");
			PlayerPrefs.SetInt ("highScore1Score", 3333360);
			PlayerPrefs.SetString ("highScore2Name", "Hank");
			PlayerPrefs.SetInt ("highScore2Score", 1068000);
			PlayerPrefs.SetString ("highScore3Name", "Steve");
			PlayerPrefs.SetInt ("highScore3Score", 1064500);
			PlayerPrefs.SetString ("highScore4Name", "Hugh");
			PlayerPrefs.SetInt ("highScore4Score", 170100);
			PlayerPrefs.SetString ("highScore5Name", "Del");
			PlayerPrefs.SetInt ("highScore5Score", 160000);
		}
		if(string.IsNullOrEmpty (PlayerPrefs.GetString("highScore6Name")))
		{
			PlayerPrefs.SetString ("highScore6Name", "You");
			PlayerPrefs.SetInt ("highScore6Score", 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
