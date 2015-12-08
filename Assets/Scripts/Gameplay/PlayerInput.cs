using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {
	public string key;
	public float speed;
	public Transform pulse;
	public string button;
	public string controllerButton;
	ParticleSystem sys;
	GameObject player;
	bool moreThanZero;

	// Use this for initialization
	void Start () {
		sys = GetComponentInChildren<ParticleSystem> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.inputType == ControllerType.keyboard)
		{
			if (Input.GetKeyDown (key))
			{
				OnMouseDown ();
			}
		}
		else if(Player.inputType == ControllerType.drum)
		{
			if (Input.GetButtonDown (button))
			{
				OnMouseDown ();
			}
		}
		else if(Player.inputType == ControllerType.controller)
		{
			if (Input.GetAxis (controllerButton) == 1 && !moreThanZero)
			{
				OnMouseDown ();
				moreThanZero = true;
			}
			else if(Input.GetAxis (controllerButton) < 1)
			{
				moreThanZero = false;
			}
			/*if(Input.GetAxis (controllerButton) == 1 && (controllerButton.Contains ("LT") || controllerButton.Contains ("RT")))
			{
				OnMouseDown ();
			}*/
		}
	}

	void OnMouseDown()
	{
		move ();
		gameObject.GetComponent<AudioSource>().Play ();
	}

	void move()
	{
		if(player.active)
		{
			Vector2 dir = (player.transform.position - transform.position).normalized;

			float dist = Vector2.Distance (player.transform.position, transform.position);
			
			//p.rigidbody.AddForce (dir * (speed/dist));
			player.GetComponent<Rigidbody2D>().AddForce (dir * (speed/dist));
			//p.rigidbody2D.velocity = dir * (speed/dist);
			if(!Player.shieldsUp)
			{
				charge ();
			}
		}

		//Transform t = (Transform)Instantiate (pulse);
		//Destroy (t.gameObject, 2);
		//for(int i = 0 ; i < sys.Length ; i++)
		//{
			sys.Emit (50);
		//}
	}

	void charge()
	{
		Player.addToShield ();
	}
}
