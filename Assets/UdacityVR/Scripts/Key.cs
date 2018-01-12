using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	//Create a reference to the KeyPoofPrefab and Door	
	[Header("Key Poof")]
	public GameObject keyPoofPrefab;
	[Header("Door")]
	public Door templeDoor;
	[Header("Storing User Has Key")]
	public UserHasKey userHasKey;

	// User Inputs
	public float degreesPerSecond = 15.0f;
	public float amplitude = 0.5f;
	public float frequency = 1f;

	// Position Storage Variables
	private Vector3 posOffset = new Vector3 ();
	private Vector3 tempPos = new Vector3 ();

	// Key Collected Animation Variables
	private float posIncrement = 0.03f;
	private float rotationSpeed = 1.0f;

	void Start () {
		posOffset = transform.position;
	}

	void Update()
	{
		// if it has not been collected - Float up/down with a Sin() 
		if (!userHasKey.KeyCollected) {
			tempPos = posOffset;
			tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
		} else { // has been collected start flying and increase rotationSpeed
			tempPos.y += posIncrement;
			rotationSpeed += 1.2f;
		}
		// Spin object around Y-Axis
		transform.Rotate (new Vector3 (0f, Time.deltaTime * degreesPerSecond * rotationSpeed, 0f), Space.World);
		transform.position = tempPos;
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		Object.Instantiate(keyPoofPrefab, gameObject.transform.position, Quaternion.Euler(-90, 0, 90));

        // Call the Unlock() method on the Door
		templeDoor.Unlock();

		// Set the Key Collected Variable to true
		userHasKey.KeyCollected = true;

		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject, 2f);
    }

}
