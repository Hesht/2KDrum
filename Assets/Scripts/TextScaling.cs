using UnityEngine;
using System.Collections;

public class TextScaling : MonoBehaviour {
	float originalWidth = 1920.0f;  // define here the original resolution
	float originalHeight = 1080.0f; // you used to create the GUI contents 
	float scale = 1.0f;

	// Use this for initialization
	void Start () {
		scale = Screen.width/originalWidth; // calculate hor scale
		
		GetComponent<GUIText>().fontSize = (int)(scale * 100);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
