using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayExhibitAudio : MonoBehaviour {
	// it is only possible to play an audio at the time
	// exhibit Logic
	private ExhibitSoundRegulator exhibitLogic;
	// Use this for initialization
	void Start() {
		exhibitLogic = GameObject.Find("exhibitLogic").GetComponent<ExhibitSoundRegulator>();
	}
	public void OnHitPlay() {
        // set new sound
        exhibitLogic.PlayExhibitSound(this.gameObject);
	}

	public void OnHitStop() {
        exhibitLogic.StopExhibitSound();
	}

}
