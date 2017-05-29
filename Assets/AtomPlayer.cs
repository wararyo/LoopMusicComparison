using UnityEngine;
using System.Collections;

public class AtomPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Play(){
		CriAtomSource s = GetComponent<CriAtomSource> ();
		s.Play ();
	}
}
