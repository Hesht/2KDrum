using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {
	public Sprite sprite;
	public string button;
	public string controllerButton;
	SpriteRenderer renderer;
	// Use this for initialization
	void Start () {
		//renderer.sprite = sprite;
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.inputType == ControllerType.keyboard)
		{
			if(Input.GetKeyDown (KeyCode.Escape))
			{
				if(Time.timeScale > 0)
				{
					Time.timeScale = 0;
				}
				else
				{
					Time.timeScale = 1;
				}
			}
		}
		else if(Player.inputType == ControllerType.drum)
		{
			if(Input.GetButtonDown(button))
			{
				if(Time.timeScale > 0)
				{
					Time.timeScale = 0;
				}
				else
				{
					Time.timeScale = 1;
				}
			}
		}
		else if(Player.inputType == ControllerType.controller)
		{
			if(Input.GetButtonDown(controllerButton))
			{
				if(Time.timeScale > 0)
				{
					Time.timeScale = 0;
				}
				else
				{
					Time.timeScale = 1;
				}
			}
		}
	}
}
