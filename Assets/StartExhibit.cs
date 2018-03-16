using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExhibit : MonoBehaviour {

    public GameObject player;
    public GameObject eventSystem;

	// start UI
    public GameObject startUI, restartUI;

	// positions - start and inside exhibit
    public GameObject startPoint, playPoint;
	
	// doors to slide
	public GameObject outsideDoor, insideDoor;

	// sliding the door positions
	public GameObject startSlidePoint, endSlidePoint;

    // raycast indicator inside the gallery to walk around
	public GameObject raycastIndicator;

	// Use this for initialization
	void Start () {
        // Move the 'player' to the 'startPoint' position.
        player.transform.position = startPoint.transform.position;

		// disable raycast movement script
		GetComponent<RaycastMovement>().enabled = false;
		startUI.SetActive(true);
		// restartUI.SetActive(false);
		raycastIndicator.SetActive(false);
	}

    public void OnClickStartButton() {
        StartCoroutine(OnStartingExhibit());
    }

	public void RestartExhibit() {}

	IEnumerator OnSlideDoor(bool isOpening) {

        outsideDoor.GetComponent<AudioSource>().Play();
		GameObject slidePoint = isOpening ? endSlidePoint : startSlidePoint;
        // slide door to the right
        iTween.MoveTo(outsideDoor,
            iTween.Hash(
                "position", slidePoint.transform.position,
                "time", 1,
                "easetype", "linear"
            )
        );

        iTween.MoveTo(insideDoor,
            iTween.Hash(
                "position", slidePoint.transform.position,
                "time", 1,
                "easetype", "linear"
            )
        );

        yield return new WaitForSeconds(1.5f);
	}

	IEnumerator MovePlayerToExhibit() {
        // Move the player to the play position.
        iTween.MoveTo(player,
            iTween.Hash(
                "position", playPoint.transform.position,
                "time", 2,
                "easetype", "linear"
            )
        );

        yield return new WaitForSeconds(2.5f);
	}
	/*NOT WORKING - DO ANIMATION, check previous projects */
    IEnumerator OnStartingExhibit() {
        // Disable the start UI.
        startUI.SetActive(false);

        // bogus
        // Debug.Log("Waiting for princess to be rescued...");
        // yield return new WaitForSeconds(2f);
        // Debug.Log("Princess was rescued!");

        // slide door to the right
        yield return StartCoroutine(OnSlideDoor(true));

		// move player
		yield return StartCoroutine(MovePlayerToExhibit());

        // slide door to original position
        yield return StartCoroutine(OnSlideDoor(false));
        //StartCoroutine(WaitXSeconds(2.5f));

        // activate restart UI & enable raycast
        // restartUI.SetActive(true);
        raycastIndicator.SetActive(true);
        GetComponent<RaycastMovement>().enabled = true;
	}

}
