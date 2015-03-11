using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getTagCount : MonoBehaviour {

	public string[] tagsToCount;

	private Text textComponent;

	void Start() {
		textComponent = gameObject.GetComponent<Text>();
	}

	// Update is called once per frame
	void Update() {
		if (tagsToCount.Length > 0) {
			int total = 0;
			foreach (string t in tagsToCount) {
				total += GameObject.FindGameObjectsWithTag(t).Length;
			}
			textComponent.text = total.ToString();
		}
	}
}
