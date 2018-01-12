using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoofPrefab;

	private bool wasClicked = false;
	private float speed = 100f;
	private float speedIncrement = 50f;

	void Update() {
		// This line spins the key - when clicked it increments the rotation
		if (wasClicked) {
			speed += speedIncrement;
		}
		transform.Rotate (Vector3.up * speed * Time.deltaTime);

	}

    public void OnCoinClicked() {
		wasClicked = true;

        // Instantiate the CoinPoof Prefab where this coin is located
		Object.Instantiate(coinPoofPrefab, gameObject.transform);
	
        // Make sure the poof animates vertically
		Destroy(gameObject, 1f);
    }

}
