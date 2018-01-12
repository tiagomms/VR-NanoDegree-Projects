using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserHasKey : MonoBehaviour {

	private bool hasKey;
	public bool KeyCollected { 
		get { return hasKey; } 
		set { hasKey = value; }
	}
	// Use this for initialization
	void Start () {
		KeyCollected = false;
	}

}
