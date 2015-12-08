using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PushSpawnLevel : MonoBehaviour {
	
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
	public float increment = 0;
	
	// Use this for initialization
	void Start () {
		largeRoids = new List<Asteroid> ();
		medRoids = new List<Asteroid> ();
		smallRoids = new List<Asteroid> ();
		explosions = new List<Explosion> ();
		Player.pushMode = true;
		
		for(int i = 0 ; i < 24 ; i++)
		{
			Transform asteroid = (Transform)Instantiate (largeRoid);
			asteroid.gameObject.SetActive (false);
			largeRoids.Add (asteroid.gameObject.GetComponent<Asteroid>());
		}
		Player.pushScore = 0;
		
		audioObj = GameObject.FindGameObjectWithTag ("Audio").GetComponent<Audio>();
		Player.countdown = countdown;
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.pushScore >= increment)
		{
			SpawnRoids();
			numOfRoids++;
			Player.countdown = 5;
			Player.countdownNeeded = false;
		}
		else
		{
			if(Player.pushScore == 0)
			{
				increment+=15;
			}
			else
			{
				increment+=increment * 2;
			}
			Player.countdownNeeded = true;
			Player.countdown -= Time.deltaTime;
			if(Player.countdown <= 0)
			{
				Player.countdown = 0;
			}
		}
		Player.pushScore += Time.deltaTime;
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
