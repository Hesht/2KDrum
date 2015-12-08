using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.countdown > 0 && Player.countdownNeeded)
		{
			GetComponent<Text>().text = Player.countdown.ToString ("N2");
		}
		else
		{
			GetComponent<Text>().text = "";
		}
	}
}
