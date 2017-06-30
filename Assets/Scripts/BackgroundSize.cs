using UnityEngine;
using System.Collections;

public class BackgroundSize : MonoBehaviour {
	void Start () {
		float heightOrtho = Camera.main.orthographicSize * 2.0f;

		float screenRatio = (float) Screen.width / (float) Screen.height;
		float widthOrtho = heightOrtho * screenRatio;

		Vector3 scale = transform.localScale;

		scale.y = heightOrtho;
		scale.x = widthOrtho;

		transform.localScale = scale;
	}
}
