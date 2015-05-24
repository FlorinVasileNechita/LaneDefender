using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	ButtonScript[] buttonArray;

	void Start() {
		buttonArray = GameObject.FindObjectsOfType<ButtonScript> ();
		foreach (ButtonScript thisButton in buttonArray) {
			thisButton.GetComponent<SpriteRenderer>().color = Color.gray;
		}
	}

	void OnMouseDown() {

		foreach (ButtonScript thisButton in buttonArray) {
			thisButton.GetComponent<SpriteRenderer>().color = Color.gray;
		}

		GetComponent<SpriteRenderer>().color = Color.white;
	}
}
