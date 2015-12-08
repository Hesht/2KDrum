using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour {
	public int score;
	public int lives;
	public string playerName;
	public int pointsPerKill;
	public float shieldTime;
	public float shieldModifier;
	public float maxShield;
	public Transform shieldPrefab;
	PlayerController cont;

	// Use this for initialization
	void Start () {
		Player.score = score;
		Player.lives = lives;
		Player.playerName = playerName;
		Player.pointsPerKill = pointsPerKill;
		Player.shieldTime = shieldTime;
		Player.shieldModifier = shieldModifier;
		Player.maxShield = maxShield;
		score = 0;
		cont = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown ("space") && Player.isAlive && Player.shieldTime > 0)
		{
			cont.activateShield ();
		}
	}

	public void addScore(int asteroidType)
	{
		Player.score += Player.pointsPerKill * asteroidType;
	}

	public void addToShield()
	{
		if (Player.shieldTime < Player.maxShield) 
		{
			Player.shieldTime += Player.shieldModifier;
		}
		else
		{
			Player.shieldTime = Player.maxShield;
		}
	}
}
