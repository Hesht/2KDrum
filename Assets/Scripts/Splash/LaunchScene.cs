using UnityEngine;
using System.Collections;

public class LaunchScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeScene(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}
}
