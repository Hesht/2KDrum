using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnLevel : MonoBehaviour {

	public int numOfRoids = 1;
	public float countdown = 5.0f;
	public int roidsLeft = 0;
	public Transform largeRoid;
	public Transform medRoid;
	public Transform smallRoid;
	public Transform explosion;
	List<Explosion> explosions;
	List<Asteroid> largeRoids;
	List<Asteroid> medRoids;
	List<Asteroid> smallRoids;
	public int roidCount = 0;
	public int explosionCount = 0;
	public Transform audioTran;
	Audio audioObj;

	// Use this for initialization
	void Start () {
		largeRoids = new List<Asteroid> ();
		medRoids = new List<Asteroid> ();
		smallRoids = new List<Asteroid> ();
		explosions = new List<Explosion> ();

		Player.pushMode = false;

		for(int i = 0 ; i < 6 ; i++)
		{
			Transform asteroid = (Transform)Instantiate (largeRoid);
			asteroid.gameObject.SetActive (false);
			largeRoids.Add (asteroid.gameObject.GetComponent<Asteroid>());
		}
		for(int i = 0 ; i < 12 ; i++)
		{
			Transform asteroid = (Transform)Instantiate (medRoid);
			asteroid.gameObject.SetActive (false);
			medRoids.Add (asteroid.gameObject.GetComponent<Asteroid>());
		}
		for(int i = 0 ; i < 24 ; i++)
		{
			Transform asteroid = (Transform)Instantiate (smallRoid);
			asteroid.gameObject.SetActive (false);
			smallRoids.Add (asteroid.gameObject.GetComponent<Asteroid>());
		}
		for(int i = 0 ; i < 24 ; i++)
		{
			Transform ex = (Transform)Instantiate (explosion);
			//ex.gameObject.SetActive (false);
			explosions.Add (ex.gameObject.GetComponent<Explosion>());
		}

		audioObj = GameObject.FindGameObjectWithTag ("Audio").GetComponent<Audio>();
		Player.countdown = countdown;
		Player.isAlive = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(roidCount <= ((numOfRoids/2) - 1))
		{
			Player.countdownNeeded = true;
			Player.countdown -= Time.deltaTime;
			if(Player.countdown <= 0)
			{
				Player.countdown = 0;
			}
		}
		if(Player.countdown == 0)
		{
			SpawnRoids();
			numOfRoids++;
			Player.countdown = 5;
			Player.countdownNeeded = false;
		}
	}

	void SpawnRoids()
	{
		Vector3 wrapmin = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
		Vector3 wrapmax = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
		if(Player.level < 4)
		{
			Player.level++;
			audioObj.setClip (Player.level);
		}
		for(int i = 0 ; i < numOfRoids ; i++)
		{
			Vector2 pos;
			if(i % 2 == 0)
			{
				pos = new Vector2(wrapmax.x, Random.Range (wrapmin.y, wrapmax.y));
			}
			else
			{
				pos = new Vector2(Random.Range (wrapmin.x, wrapmax.x), wrapmax.y);
			}
			foreach(Asteroid a in largeRoids)
			{
				if(!a.gameObject.active)
				{
					a.transform.position = pos;
					a.initiate (Vector2.zero);
					roidCount++;
					break;
				}
			}
		}
	}

	public void SpawnRoid(int size, Vector2 pos, Vector2 pushForce)
	{
		if(size == 2)
		{
			foreach(Asteroid a in medRoids)
			{
				if(!a.gameObject.active)
				{
					a.transform.position = pos;
					a.initiate (pushForce);
					roidCount++;
					break;
				}
			}
		}
		if(size == 1)
		{
			foreach(Asteroid a in smallRoids)
			{
				if(!a.gameObject.active)
				{
					a.transform.position = pos;
					a.initiate (pushForce);
					roidCount++;
					break;
				}
			}
		}
	}

	public void explode(Vector2 pos)
	{
		if(explosionCount >= explosions.Count)
		{
			explosionCount = 0;
		}
		Explosion ex = explosions [explosionCount];
		ex.transform.position = pos;
		ex.GetComponent<ParticleSystem>().Emit (10);
		explosionCount++;
	}
}
