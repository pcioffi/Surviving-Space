using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour {
	GameObject player;

	private PlayerMovement thePlayerMove;
	private PlayerShooting thePlayerShoot;

	private bool leftOn, rightOn, boostOn, shootOn;

	void Start () {
		if (player == null) {
			// Find player
			player = GameObject.FindGameObjectWithTag("Player");

			if (player != null) {
				thePlayerMove = FindObjectOfType<PlayerMovement> ();
				thePlayerShoot = FindObjectOfType<PlayerShooting> ();
			}
		}
	}

	void Update() {
		if (player == null) {
			// Find player
			player = GameObject.FindGameObjectWithTag ("Player");

			if (player != null) {
				thePlayerMove = FindObjectOfType<PlayerMovement> ();
				thePlayerShoot = FindObjectOfType<PlayerShooting> ();
			}
		}

		if (leftOn) {
			thePlayerMove.Rotate (-1);
		}
		if (rightOn) {
			thePlayerMove.Rotate (1);
		}
		if (boostOn) {
			thePlayerMove.Move (1);
		}
		if (shootOn) {
			thePlayerShoot.Shoot (true);
		}
	}

	public void LeftOn(){
		leftOn = true;
	}

	public void RightOn(){
		rightOn = true;
	}

	public void NoRotOn(){
		leftOn = false;
		rightOn = false;
	}

	public void BoostOn(){
		boostOn = true;
	}

	public void NoBoostOn(){
		boostOn = false;
	}

	public void ShootOn(){
		shootOn = true;
	}

	public void NoShootOn(){
		shootOn = false;
	}
}
