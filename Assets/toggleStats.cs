using UnityEngine;
using System.Collections;

public class toggleStats : MonoBehaviour {

	public bool isActive = false;

	// Use this for initialization
	void Start() {
		gameObject.SetActive(isActive);
	}
	
	// Update is called once per frame
	public void Toggle() {
		isActive = !isActive;
		gameObject.SetActive(isActive);
	}
}
