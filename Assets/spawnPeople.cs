using UnityEngine;
using System.Collections;

public class spawnPeople : MonoBehaviour {

	public Transform person;

	void SpawnPerson() {
		Vector3 location = Random.insideUnitSphere;
		location *= (transform.localScale.x + transform.localScale.z);
		location += transform.position;
		location.y = 0.001f; //ground the person

		Instantiate(person, location, transform.rotation);
	}

	// Use this for initialization
	void Start() {
		int spawned = 0;
		int numPeople = Mathf.RoundToInt(Random.Range(5, 12));

		while (spawned < numPeople) {
			SpawnPerson();
			spawned += 1;
		}
	}
}
