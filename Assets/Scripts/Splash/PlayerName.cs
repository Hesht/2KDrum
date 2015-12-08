using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string playerName = PlayerPrefs.GetString ("name");
		GetComponent<Text>().text = playerName;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
