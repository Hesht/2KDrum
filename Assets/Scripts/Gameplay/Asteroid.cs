using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {
	public float speed;
	public float maxSpeed;
	public float minSpeed;
	public int type;
	public Vector2 oldForce;
	SpawnLevel lev;
	GameObject p;
	ParticleSystem sys;
	public float vel;

	// Use this for initialization
	void Start () {
		oldForce = new Vector2 (Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f)).normalized;
		if (oldForce.x == 0) {
			oldForce.x = 0.1f;
				}
		Vector2 forcePos = oldForce;
		GetComponent<Rigidbody2D>().AddForce (forcePos * maxSpeed);

		lev = Camera.main.GetComponent<SpawnLevel> ();
		p = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		/*if (rigidbody2D.velocity.magnitude > maxSpeed) 
		{
			rigidbody2D.velocity = rigidbody2D.velocity.normalized * maxSpeed;
		} 
		else if (rigidbody2D.velocity.magnitude < minSpeed) 
		{
			rigidbody2D.velocity = rigidbody2D.velocity.normalized * minSpeed;
		}
		vel = rigidbody2D.velocity.magnitude;
		vel = rigidbody2D.velocity.magnitude;*/
		transform.Rotate (new Vector3 (0, 0, 1), 0.1f * Time.timeScale);
	}

	void PushForce(Vector2 force)
	{
		GetComponent<Rigidbody2D>().AddForce (force * speed);
	}

	void OnBecameInvisible()
	{
		try
		{
			Vector3 pos = transform.position;
			Vector3 wrapmin = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
			Vector3 wrapmax = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
			
			if (transform.position.x < wrapmin.x)
			{
				pos.x = pos.x * -1;
				//vel.x = vel.x * -1;
			}
			else if (transform.position.x > wrapmax.x)
			{
				pos.x = pos.x * -1;
				//vel.x = vel.x * -1;
			}
			if (transform.position.y < wrapmin.y)
			{
				pos.y = pos.y * -1;
				//vel.y = vel.y * -1;
			}
			else if (transform.position.y > wrapmax.y)
			{
				pos.y = pos.y * -1;
				//vel.y = vel.y * -1;
			}
			transform.position = pos;
		}
		catch(UnityException ex)
		{
			Debug.Log (ex.Message);
		}
		catch(System.Exception ex)
		{

		}
	}

	public void initiate(Vector2 pushforce)
	{
		gameObject.SetActive (true);
		oldForce = new Vector2 (Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f)).normalized;
		Vector2 forcePos = oldForce;
		GetComponent<Rigidbody2D>().AddForce (forcePos * speed);
		if(pushforce != null)
		{
			PushForce (pushforce);
		}
	}

	public void destroyed()
	{
		GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		lev.roidCount--;
		lev.explode (transform.position);
		if (type > 1) 
		{
			if(type == 3 || type == 2)
			{
				for(int i = 0 ; i < 2 ; i++)
				{
					lev.SpawnRoid (type - 1, transform.position, p.GetComponent<Rigidbody2D>().velocity.normalized);
				}
			}
		}
		gameObject.SetActive (false);
	}
}
