using UnityEngine;
using System.Collections;

public class BackgroundTap : MonoBehaviour {
	public string button;
	public string controllerButton;
	PlayerController p;
	// Use this for initialization
	void Start () {
		p = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.inputType == ControllerType.controller)
		{
			if(Input.GetButtonDown (controllerButton))
			{
				OnMouseDown ();
			}
		}
		else
		{
			if(Input.GetButtonDown (button))
			{
				OnMouseDown ();
			}
		}
	}

	void OnMouseDown()
	{
		if(Player.isAlive && Player.shieldTime > 0)
		{
			p.activateShield ();
		}
	}
}
