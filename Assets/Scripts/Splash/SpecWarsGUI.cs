using UnityEngine;
using System.Collections;

public class SpecWarsGUI : MonoBehaviour {

	public Vector2 startPos;
	public Vector2 highScorePos;
	public Vector2 inputNamePos = new Vector2(500,100);
	public Vector2 survivalModePos;
	public Vector2 buttonSize;
	float scale = 0.5f; 
	GUIStyle bigFontSize = new GUIStyle ();
	string name = "Player1";
	float originalWidth = 1920.0f; 
	Rect plName;
	Rect start;
	Rect highScores; 
	Rect survivalMode; 

	// Use this for initialization
	void Start () {
		if(!string.IsNullOrEmpty (PlayerPrefs.GetString ("name")))
		{
			name = PlayerPrefs.GetString ("name");
		}
		scale = Screen.width / originalWidth;
		
		bigFontSize.fontSize = (int)(80 * scale);
		bigFontSize.normal.textColor = Color.white;

		plName = new Rect (Screen.width/2 - ((inputNamePos.x * scale)/2), (inputNamePos.y * scale), buttonSize.x * scale, buttonSize.y * scale);
		start = new Rect (Screen.width/2 - ((startPos.x * scale)/2), (startPos.y * scale), buttonSize.x * scale, buttonSize.y * scale);
		highScores = new Rect (Screen.width/2 - ((highScorePos.x * scale)/2), (highScorePos.y * scale), buttonSize.x * scale, buttonSize.y * scale);
		survivalMode = new Rect (Screen.width/2 - ((survivalModePos.x * scale)/2), (survivalModePos.y * scale), buttonSize.x * scale, buttonSize.y * scale);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		bool startGame = false;
		bool highScore = false;
		bool survival = false;
		bigFontSize.border = GUI.skin.textField.border;
		//InputName
		GUI.color = Color.white;
		GUI.backgroundColor = Color.white;
		GUI.contentColor = Color.white;
		GUI.skin.textField.fontSize = (int)(80 * scale);
		name = GUI.TextField (plName, name);//, bigFontSize );
		PlayerPrefs.SetString ("name", name);

		//Start
		GUI.skin.button.fontSize = (int)(80 * scale);
		startGame = GUI.Button (start, "Classic Mode");
		highScore = GUI.Button (highScores, "High Scores");
		survival = GUI.Button (survivalMode, "Survival Mode");

		if (startGame) 
		{
			Application.LoadLevel("Gameplay");
		} 
		else if (highScore) 
		{
			PlayerPrefs.SetString ("LastLevel", "Splash");
			Application.LoadLevel("HighScores");
		}
		else if (survival)
		{
			Application.LoadLevel("Pusher Mode");
		}
	}
}
