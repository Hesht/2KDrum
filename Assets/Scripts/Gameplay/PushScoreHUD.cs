using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PushScoreHUD : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.pushScore > 10)
		{
			GetComponent<Text>().text = Player.pushScore.ToString ("n5");
		}
		else
		{
			GetComponent<Text>().text = "0" + Player.pushScore.ToString ("n5");
		}
	}
}
