using UnityEngine;
using System.Collections;

public class GameOverGUI : MonoBehaviour {
	
	public Vector2 playAgainPos = new Vector2(500,100);
	public Vector2 highScoresPos = new Vector2(500,100);
	public Vector2 buttonSize;
	float scale = 0.0f; 
	GUIStyle bigFontSize = new GUIStyle ();
	string name = "Player1";
	float originalWidth = 1920.0f; 
	Rect playAgain;
	Rect highScores; 

	// Use this for initialization
	void Start () {
		if(!string.IsNullOrEmpty (PlayerPrefs.GetString ("name")))
		{
			name = PlayerPrefs.GetString ("name");
		}
		scale = Screen.width / originalWidth;
		
		bigFontSize.fontSize = (int)(80 * scale);
		bigFontSize.normal.textColor = Color.white;
		
		playAgain = new Rect (Screen.width/2 - ((playAgainPos.x * scale)/2), (playAgainPos.y * scale), buttonSize.x * scale, buttonSize.y * scale);
		highScores = new Rect (Screen.width/2 - ((highScoresPos.x * scale)/2), (highScoresPos.y * scale), buttonSize.x * scale, buttonSize.y * scale);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		bool startGame = false;
		bool highScore = false;
		bigFontSize.border = GUI.skin.textField.border;
		//InputName
		GUI.color = Color.white;
		GUI.backgroundColor = Color.white;
		GUI.contentColor = Color.white;
		
		//Start
		GUI.skin.button.fontSize = (int)(80 * scale);
		startGame = GUI.Button (playAgain, "Play Again");
		highScore = GUI.Button (highScores, "High Scores");
		
		if (startGame) 
		{
			Application.LoadLevel("Gameplay");
		} 
		else if (highScore) 
		{
			PlayerPrefs.SetString ("LastLevel", "Splash");
			Application.LoadLevel("HighScores");
		}
	}
}
