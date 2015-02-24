using UnityEngine;
using System.Collections;

public class setOnFire : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<AIPath>().SetOnFire();
		}
	}

}
