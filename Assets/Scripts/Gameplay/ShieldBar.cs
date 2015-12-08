using UnityEngine;
using System.Collections;

public class ShieldBar : MonoBehaviour {
	public float barDisplay = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	void Update()
	{
		float perc = (Player.shieldTime / Player.maxShield);
		barDisplay = perc * 4;
		if(barDisplay > 4)
		{
			barDisplay = 4;
		}
		transform.localScale = new Vector2 (barDisplay, transform.localScale.y);
	}
}
