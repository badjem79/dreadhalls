using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabPickups : MonoBehaviour {

	private AudioSource pickupSoundSource;

	private bool goingToExit = false;

	void Awake() {
		pickupSoundSource = DontDestroy.instance.GetComponents<AudioSource>()[1];
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.tag == "Pickup" && !goingToExit) {
			goingToExit = true; //avoid multiple collisions
			DontDestroy.level++;
			pickupSoundSource.Play();
			SceneManager.LoadScene("Play");
		}
	}
}
