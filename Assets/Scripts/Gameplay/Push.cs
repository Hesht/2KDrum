using UnityEngine;
using System.Collections;

public class Push : MonoBehaviour {

	public Vector2 scale;
	public Vector3 scaleInc;
	public Vector3 maxScale;
	GameObject p;

	// Use this for initialization
	void Start () {
		p = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = p.transform.position;
		transform.localScale += scaleInc;
		if(transform.localScale.x >= maxScale.x)
		{
			Player.immortal = false;
			gameObject.SetActive (false);
			reset ();
		}
	}

	public void reset()
	{
		transform.localScale = scale;
	}
}
