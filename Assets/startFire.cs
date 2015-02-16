using UnityEngine;
using System.Collections;

public class startFire : MonoBehaviour {

	public Transform fire;
	private bool fireStarted = false;

	void StartFire(Vector3 location) {
		if (!fireStarted) {
			location.y = 0.2f; // ground the fire
			fire = (Transform) Instantiate(fire, location, transform.rotation);
			fireStarted = true;
		}
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetMouseButton(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)) {
				StartFire(hit.point);
			}
		}
	}
}
