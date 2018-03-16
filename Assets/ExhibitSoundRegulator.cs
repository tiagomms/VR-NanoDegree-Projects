using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitSoundRegulator : MonoBehaviour {

	// background audiosource on Player
	public AudioSource backgroundSound;
	private GameObject currentExhibitSound;
	// Exhibit AudioSource regulation (only one at the time)
	private AudioSource _audioSource;
	private GameObject _playButton;
	private GameObject _stopButton;


	// stop exhibit sound clip
	// start background music
	public void StopExhibitSound() {
		if (currentExhibitSound != null) {
			_stopButton.SetActive(false);
			_audioSource.Stop();
			_playButton.SetActive(true);
			currentExhibitSound = null;

			backgroundSound.Play();
		}
	}

	// stop background music
	// play exhibit sound clip
	public void PlayExhibitSound(GameObject exhibitionSound) {

		// stop current clip - either from exhibit sound or from background
		if (currentExhibitSound == null)
			backgroundSound.Stop();
		else
			_audioSource.Stop();

		// set exhibition sound and all its important components
		currentExhibitSound = exhibitionSound;
		_audioSource = currentExhibitSound.GetComponent<AudioSource>();
		_playButton = currentExhibitSound.transform.Find("Play_Button").gameObject;	
		_stopButton = currentExhibitSound.transform.Find("Stop_Button").gameObject;

		// start play audio
		_playButton.SetActive(false);
		_audioSource.Play();
		_stopButton.SetActive(true);
	}

	void Update() {
		if (currentExhibitSound != null && !_audioSource.isPlaying) {
			StopExhibitSound();
		}
	}
}
