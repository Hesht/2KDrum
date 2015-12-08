using UnityEngine;
using System.Collections;

public class WallCollision : MonoBehaviour {
	public Transform particle;
	ParticleSystem sys;
	// Use this for initialization
	void Start () {
		//particleSystem = particle.particleSystem;
		//particleSystem.transform.Rotate (new Vector3 (0, 1, 0), 90);
		sys = GetComponentInChildren<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		ContactPoint2D point = col.contacts [0];

		//Transform obj = (Transform)Instantiate (particle, point.point, particle.rotation);
		//Destroy (obj.gameObject, 1);
		sys.transform.position = point.point;
		//particleSystem.Emit (point.point, new Vector3(1,1,1) * 50, 1, 1, Color.red);
		sys.Emit (50);
	}
}
