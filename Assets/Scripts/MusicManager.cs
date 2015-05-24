using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip levelMusic; 
	private AudioSource source;

	void Awake () {
		DontDestroyOnLoad (gameObject);
	}

	void Start() {
		source = GetComponent<AudioSource> ();
		source.clip = levelMusic;
		source.Play ();
		source.loop = true;
	}

	public void ChangeVolume(float volume) {
		GetComponent<AudioSource> ().volume = volume;
	}
}
