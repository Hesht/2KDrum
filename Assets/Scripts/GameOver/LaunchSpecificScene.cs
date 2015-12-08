using UnityEngine;
using System.Collections;

public class LaunchSpecificScene : MonoBehaviour {
	public string controllerScene;
	public string drumScene;
	public string keyboardScene;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void changeScene()
	{
		if(Player.inputType == ControllerType.controller)
		{
			Application.LoadLevel (controllerScene);
		}
		else if(Player.inputType == ControllerType.keyboard)
		{
			Application.LoadLevel (keyboardScene);
		}
		else if(Player.inputType == ControllerType.drum)
		{
			Application.LoadLevel (drumScene);
		}
	}
}
