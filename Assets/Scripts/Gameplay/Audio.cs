using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {
	public AudioClip layer1;
	public AudioClip layer2;
	public AudioClip layer3;
	public AudioClip layer4;
	AudioClip currentLayer;
	bool switchTrack;

	// Use this for initialization
	void Start () {
		currentLayer = layer1;
		GetComponent<AudioSource>().clip = currentLayer;
		GetComponent<AudioSource>().loop = true;
		GetComponent<AudioSource>().Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if(!GetComponent<AudioSource>().isPlaying)
		{
			GetComponent<AudioSource>().clip = currentLayer;
			GetComponent<AudioSource>().loop = true;
			GetComponent<AudioSource>().Play ();
		}
	}
	public void setClip(int clipNo)
	{
		switch(clipNo)
		{
			case 1:
				currentLayer = layer1;
				GetComponent<AudioSource>().loop = false;
				break;
			case 2:
				currentLayer = layer2;
				GetComponent<AudioSource>().loop = false;
				break;
			case 3:
				currentLayer = layer3;
				GetComponent<AudioSource>().loop = false;
				break;
			case 4:
				currentLayer = layer4;
				GetComponent<AudioSource>().loop = false;
				break;
			default:
				break;
		}
	}
}
