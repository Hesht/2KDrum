﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputPlayerName : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void playerName(string name)
	{
		PlayerPrefs.SetString ("name", name);
	}
}