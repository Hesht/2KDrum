using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {
	public float timeAlive;
	bool shouldPush;
	GameObject p;
	Push push;
	// Use this for initialization
	void Start () {
		p = GameObject.FindGameObjectWithTag ("Player");
		push = p.GetComponentInChildren<Push> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (timeAlive <= 0) 
		{
			Player.shieldsUp = false;
			push.gameObject.SetActive(true);
			gameObject.SetActive (false);
		} 
		else 
		{
			transform.position = p.transform.position;
			timeAlive -= Time.deltaTime;
			Player.shieldTime = timeAlive;
			if(Player.shieldTime < 0)
			{
				Player.shieldTime = 0;
			}
		}
		if(!gameObject.GetComponent<AudioSource>().isPlaying)
		{
			gameObject.GetComponent<AudioSource>().Play ();
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.collider.tag == "Asteroid") 
		{
			Asteroid a = col.collider.GetComponent<Asteroid>();
			Player.addScore (a.type);
			a.destroyed ();
		}
	}
}
