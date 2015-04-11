using UnityEngine;
using System.Collections;

public class setEvacuated : MonoBehaviour {

	// Use this for initialization
	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<AIPath>().SetEvacuated();
		}
	}

}