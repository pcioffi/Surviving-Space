using UnityEngine;
using System.Collections;

public class LivesGUI : MonoBehaviour {
	private PlayerSpawner thePlayerSpawner;
	private int numLives;
	private GameObject playerInstance;

	public TextEditor lives;

	void Start () {
		thePlayerSpawner = FindObjectOfType<PlayerSpawner> ();
		numLives = thePlayerSpawner.numLives;
		playerInstance = thePlayerSpawner.playerInstance;
	}

	void Update () {
		if (numLives > 0 || playerInstance != null) {
			lives.text = "x" + numLives;
		} else {
			GUI.Label (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 50), "Game Over!");
		}
	}
}
