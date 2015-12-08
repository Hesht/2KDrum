using UnityEngine;
using System.Collections;

public class ChooseInputMethod : MonoBehaviour {

	public ControllerType type;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void chooseType()
	{
		Player.inputType = type;
	}
}
