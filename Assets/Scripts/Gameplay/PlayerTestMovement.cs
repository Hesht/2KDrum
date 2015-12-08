using UnityEngine;
using System.Collections;

public class PlayerTestMovement : MonoBehaviour {
	public float speed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown  ("w")) 
		{
			addForce (new Vector2(0,speed));
		}
		//if (Input.GetKeyDown  ("a")) 
		//{
		//	addForce (new Vector2(-speed,0));
		//}
		if (Input.GetKeyDown  ("s")) 
		{
			addForce (new Vector2(0,-speed));
		}
		if (Input.GetKeyDown  ("d")) 
		{
			addForce (new Vector2(speed,0));
		}
	}

	public void addForce(Vector2 force)
	{
		GetComponent<Rigidbody2D>().AddForce (force);
	}

	void FixedUpdate()
	{
	}
}
