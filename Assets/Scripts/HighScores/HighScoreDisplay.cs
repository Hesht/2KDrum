using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text>().text = "";
		for(int i = 1 ; i < 7 ; i++)
		{
			GetComponent<Text>().text += PlayerPrefs.GetString ("highScore" + i.ToString () + "Name") + ": " +
							PlayerPrefs.GetInt ("highScore" + i.ToString () + "Score").ToString () +
							"\n";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Application.LoadLevel (PlayerPrefs.GetString ("LastLevel"));
		}
	}
}
