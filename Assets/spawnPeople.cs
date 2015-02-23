using UnityEngine;
using System.Collections;

public class spawnPeople : MonoBehaviour {

	public Transform person;
	public int minPeople;
	public int maxPeople;
	public bool canBeEmpty;

	void SpawnPerson() {
		Vector3 location = Random.insideUnitSphere;
		location *= (transform.localScale.x + transform.localScale.z);
		location += transform.position;
		location.y = (person.transform.localScale.y / 2) + 0.001f; //ground the person

		Instantiate(person, location, transform.rotation);
	}

	// Use this for initialization
	void Start() {
		int spawned = 0;
		int numPeople = Mathf.RoundToInt(Random.Range(minPeople, maxPeople));
		bool dontSpawn = (Random.value > 0.7f);

		if (dontSpawn) {
			return;
		}

		while (spawned < numPeople) {
			SpawnPerson();
			spawned += 1;
		}
	}
}
