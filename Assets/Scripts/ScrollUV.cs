using UnityEngine;
using System.Collections;

public class ScrollUV : MonoBehaviour {

	public float backgroundSpeed = 0.1f;

	void Update () {
		MeshRenderer mr = GetComponent<MeshRenderer> ();
		Material mat = mr.material;
		Vector2 offset = mat.mainTextureOffset;
		offset.x += Time.deltaTime * backgroundSpeed;

		mat.mainTextureOffset = offset;
	}
}
