using UnityEngine;
using System.Collections;

public class BGMUpdate : MonoBehaviour {

	public float loopEnd = 0;
	public float loopPoint = 0;
	public AudioClip clip;

	AudioSource source;

	private bool isPlaying = false;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isPlaying) {
			if (source.time >= loopEnd) {
				source.time = loopPoint;
			}
		}
	}

	public void Play(){
		source.clip = clip;
		source.loop = false;
		source.Play ();
		isPlaying = true;
	}
}
