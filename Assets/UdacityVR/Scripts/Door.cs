using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	[Header("Animator")]
	public Animator doorOpeningAnimation = null;

	[Header("Sounds")]
	public AudioClip lockedDoor;
	public AudioClip openingDoor;
	public AudioSource soundSource;

	// Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	// Create a boolean value called "opening" that can be checked in Update() 
	private bool locked = true;
	private bool opening = false;

	private BoxCollider _doorCollider;

	void Awake() {
		soundSource.clip = lockedDoor;
		_doorCollider = gameObject.GetComponent<BoxCollider> ();
	}

	void Start() {
		doorOpeningAnimation.StartPlayback ();
	}

	void Update() {
		// If the door is opening and it is not fully raised
		if (opening && _doorCollider.enabled) { //not fully raised
			// Animate the door raising up
			doorOpeningAnimation.StopPlayback();
			_doorCollider.enabled = false;
		}
    }

    public void OnDoorClicked() {
		// If the door is clicked and unlocked
		// - clicked is triggered by the event system
		if (locked == false) {
			soundSource.clip = openingDoor;			
			// Set the "opening" boolean to true
			opening = true;
			doorOpeningAnimation.SetBool ("startOpening", true);
		}
		// Play either sound to indicate the door is locked  or open
		soundSource.Play();
    }

    public void Unlock()
	{
        // You'll need to set "locked" to false here
		locked = false;
    }
}
