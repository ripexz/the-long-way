using UnityEngine;
using System.Collections;

public class toggleSpawners : MonoBehaviour {

	private MeshRenderer[] spawnerRenderers; 
	public bool visible;

	// Use this for initialization
	void Start() {
		visible = false;
		spawnerRenderers = gameObject.GetComponentsInChildren<MeshRenderer>();
	}

	public void Toggle() {
		visible = !visible;
		foreach (MeshRenderer renderer in spawnerRenderers) {
			renderer.enabled = visible;
		}
	}
}
