using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class calculateTime : MonoBehaviour {

	private bool running = false;
	private Text text;
	private float started;

	// Use this for initialization
	void Start() {
		text = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update() {
		if (running) {
			if (GameObject.FindGameObjectsWithTag("Normal").Length == 0) {
				running = false;
			}
			else {
				float secs = Time.time - started;
				text.text = secs.ToString("f2") + " s";
			}
		}
	}

	public void StartTimer() {
		started = Time.time;
		running = true;
	}
}
