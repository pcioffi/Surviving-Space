using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
	GameObject playerSpawner;
	public GameObject restart;
	public PlayerSpawner thePlayerSpawner;

	bool otherBool;

	void Start () {
		if (playerSpawner == null) {
			playerSpawner = GameObject.FindGameObjectWithTag("Respawn");

			if (playerSpawner != null)
				thePlayerSpawner = FindObjectOfType<PlayerSpawner> ();
		}

		otherBool = true;
	}

	void Update () {
		/*if (thePlayerSpawner.playerIsDead && otherBool) {
			otherBool = false;
			GameObject restartSpawner = (GameObject) Instantiate (restart);
			restartSpawner.
		}*/
	}
}
