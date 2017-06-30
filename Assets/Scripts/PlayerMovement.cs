using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float maxSpeed = 3.5f;
	public float rotSpeed = 180f;

	float shipBoundaryRadius = 0.5f;

	void Start () {

	}

	void Update () {
		// Rotate ship
		Rotate(Input.GetAxis ("Horizontal"));

		// Move forward or backward
		Move(Input.GetAxis ("Vertical"));

		// Restricting ship to camera dimensions
		Vector3 pos = transform.position;
		if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize) {
			pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
		}
		if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize) {
			pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
		}

		float screenRatio = (float) Screen.width / (float) Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;

		if (pos.x + shipBoundaryRadius > widthOrtho) {
			pos.x = widthOrtho - shipBoundaryRadius;
		}
		if (pos.x - shipBoundaryRadius < -widthOrtho) {
			pos.x = -widthOrtho + shipBoundaryRadius;
		}

		// Setting the position on the next frame
		transform.position = pos;
	}

	public void Rotate(float rotInput){
		Quaternion rot = transform.rotation;
		float z = rot.eulerAngles.z;
		z -= rotInput * rotSpeed * Time.deltaTime;
		rot = Quaternion.Euler(0,0,z);
		transform.rotation = rot;
	}

	public void Move(float moveInput){
		Quaternion rot = transform.rotation;
		Vector3 pos = transform.position;
		Vector3 velocity = new Vector3 (0, moveInput * maxSpeed * Time.deltaTime, 0);
		pos += rot * velocity;
		transform.position = pos;
	}
}

/*
		//Rotation
		Quaternion rot = transform.rotation;
		float z = rot.eulerAngles.z;
		z -= Input.GetAxis ("Horizontal") * rotSpeed * Time.deltaTime;
		rot = Quaternion.Euler(0,0,z);
		transform.rotation = rot;
*/

/*
		//Move
		Quaternion rot = transform.rotation;
		Vector3 pos = transform.position;
		Vector3 velocity = new Vector3 (0, Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime, 0);
		pos += rot * velocity;
*/

