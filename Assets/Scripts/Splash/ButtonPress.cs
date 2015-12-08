using UnityEngine;
using System.Collections;

public class ButtonPress : MonoBehaviour {

	public string buttonName;
	public string controllerButtonName;
	public string launchScene;
	public string controllerScene;
	public string drumScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.inputType == ControllerType.controller)
		{
			if(Input.GetButtonDown (controllerButtonName))
			{
				Application.LoadLevel (controllerScene);
			}
		}
		else if(Player.inputType == ControllerType.drum)
		{
			if(Input.GetButtonDown (buttonName))
			{
				if(Player.inputType == ControllerType.drum)
				{
					Application.LoadLevel (drumScene);
				}
				else
				{
					Application.LoadLevel (launchScene);
				}
			}
		}
	}
}
