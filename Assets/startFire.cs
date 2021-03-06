﻿using UnityEngine;
using System.Collections;

public class startFire : MonoBehaviour {

	public Transform fire;
	private bool fireStarted = false;
	private calculateTime timer;

	void StartFire(Vector3 location) {
		if (!fireStarted) {
			GameObject[] people = GameObject.FindGameObjectsWithTag("Player");

			location.y = 0.2f; // ground the fire
			fire = (Transform) Instantiate(fire, location, transform.rotation);
			fireStarted = true;

			foreach (GameObject person in people) {
				person.GetComponent<AIPath>().enabled = true;
			}

			timer.StartTimer();
		}
	}

	void Start() {
		timer = GameObject.Find("TimeText").GetComponentInChildren<calculateTime>();
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)) {
				StartFire(hit.point);
			}
		}
	}
}
