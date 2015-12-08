using UnityEngine;
using System.Collections;

public class PushBackgroundTap : MonoBehaviour {
	PlayerController p;
	// Use this for initialization
	void Start () {
		p = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown()
	{
		if(Player.isAlive)
		{
			p.activatePush ();
		}
	}
}
