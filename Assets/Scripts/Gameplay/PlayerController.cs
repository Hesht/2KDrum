using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float maxSpeed;
	public float vel;
	public float minSpeed;
	public Transform death;
	public Transform audioTran;
	Audio audioObj;
	GameObject deathAnim;
	Shield shield;
	public GameObject push;

	// Use this for initialization
	void Start () {
		Transform d = (Transform)Instantiate (death);
		deathAnim = d.gameObject;
		
		audioObj = GameObject.FindGameObjectWithTag ("Audio").GetComponent<Audio>();
		shield = gameObject.GetComponentInChildren<Shield> ();
		shield.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Rigidbody2D>().velocity.magnitude > maxSpeed) 
		{
			GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * maxSpeed;
		} 
		else if (GetComponent<Rigidbody2D>().velocity.magnitude < minSpeed) 
		{
			GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * minSpeed;
		}
		vel = GetComponent<Rigidbody2D>().velocity.magnitude;
		
		/*if (rigidbody.velocity.magnitude > maxSpeed) 
		{
			rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
		}
		vel = rigidbody.velocity.magnitude;*/
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Asteroid" && !Player.immortal)
		{
			deathAnim.transform.position = transform.position;
			deathAnim.GetComponent<ParticleSystem>().Emit (30);
			Player.loseLife ();
			audioObj.setClip (1);
			Player.level = 1;
			gameObject.SetActive (false);
			Player.isAlive = false;
			if(Player.lives <= 0)
			{
				PlayerPrefs.SetInt ("score",Player.score);
				Application.LoadLevel ("GameOver");
			}
		}
	}

	public void activateShield()
	{
		shield.gameObject.SetActive (true);
		shield.timeAlive = Player.shieldTime;
	}
	
	public void activatePush()
	{
		if(!push.active)
		{
			push.SetActive (true);
		}
	}
}
