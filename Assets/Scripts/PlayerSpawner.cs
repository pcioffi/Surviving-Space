using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

	public GameObject playerPrefab;
	public GameObject playerInstance;

	public GUIStyle liveStyle = new GUIStyle();
	public GUIStyle goStyle = new GUIStyle();
	public bool playerIsDead = false;

	public int numLives = 4;

	public GameObject restart;

	float respawnTimer;

	void Start () {
		SpawnPlayer ();
	}

	void SpawnPlayer () {
		numLives--;
		respawnTimer = 1;
		playerInstance = (GameObject)Instantiate (playerPrefab, transform.position, Quaternion.identity);
	}

	void Update () {
		if (playerInstance == null && numLives > 0) {
			respawnTimer -= Time.deltaTime;

			if (respawnTimer <= 0) {
				SpawnPlayer ();
			}
		}
	}

	void OnGUI () {
		if (numLives > 0 || playerInstance != null) {
			GUI.Label (new Rect (20, 0, 100, 100), "x" + numLives, liveStyle);
		} else {
			GUI.Label (new Rect (20, 0, 100, 100), "x0", liveStyle);
			GUI.Label (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 50, 100, 50), "Game Over!", goStyle);
			playerIsDead = true;
		}
	}
}
