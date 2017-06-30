using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
	public Vector3 bulletOffset = new Vector3 (0, 0.5f, 0);
	public GameObject bulletPrefab;
	int bulletLayer;
	public float fireDelay = 0.25f;

	float cooldownTimer = 0;

	void Start () {
		bulletLayer = gameObject.layer;
	}

	void Update () {
		Shoot(Input.GetButton ("Fire1"));
	}

	public void Shoot(bool shootInput){
		cooldownTimer -= Time.deltaTime;

		if (shootInput && cooldownTimer <= 0) {
			Debug.Log ("Pew!");
			cooldownTimer = fireDelay;

			Vector3 offset = transform.rotation * bulletOffset;

			GameObject bulletGO = (GameObject)Instantiate (bulletPrefab, transform.position + offset, transform.rotation);
			bulletGO.layer = bulletLayer;
		}
	}
}
