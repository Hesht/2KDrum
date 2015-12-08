using UnityEngine;
using System.Collections;

public class FlashEnd : MonoBehaviour {
	public float _timeOfFade=0;
	float delta;
	
	// Use this for initialization
	void Start () {
		SpriteRenderer rend = gameObject.GetComponent <SpriteRenderer>();
		Color col = rend.color;
		col.a = 1.0f;
		rend.color = col;
	}
	
	// Update is called once per frame
	void Update () {
		SpriteRenderer rend = gameObject.GetComponent <SpriteRenderer>();
		delta=(1/_timeOfFade)*Time.deltaTime;
		Color col = rend.color;
		col.a -= delta;
		rend.color = col;
	}
	
	public void setFlash()
	{
		SpriteRenderer rend = gameObject.GetComponent <SpriteRenderer>();
		Color col = rend.color;
		col.a = 1;
		rend.color = col;
	}
}
