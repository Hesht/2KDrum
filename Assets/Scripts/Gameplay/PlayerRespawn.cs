using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour {
	public float respawnTime;
	float waitTime;
	GameObject player;
	Push push;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		push = player.GetComponentInChildren<Push> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(!player.active)
		{
			waitTime+=Time.deltaTime;
		}
		if(waitTime > respawnTime)
		{
			Player.immortal = true;
			player.transform.position = Vector2.zero;
			player.SetActive (true);
			push.gameObject.SetActive (true);
			Player.isAlive = true;
			waitTime = 0;
		}
	}
}
