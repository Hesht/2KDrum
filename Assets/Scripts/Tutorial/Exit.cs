using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Escape) || Input.GetButtonDown("Start"))
	   	{
			if(Player.inputType == ControllerType.drum)
			{
				Application.LoadLevel ("MainMenu");
			}
			else if(Player.inputType == ControllerType.keyboard)
			{
				Application.LoadLevel ("KeyboardMenu");
			}
			else if(Player.inputType == ControllerType.drum)
			{
				Application.LoadLevel ("MainMenu");
			}
		}
	}
}
