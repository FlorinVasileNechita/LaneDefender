using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	private GameObject parent;

	void Start() {
		parent = GameObject.Find ("Defenders");
		   
		if (!parent) {
			parent = new GameObject("Defenders");
		}
	}

	void OnMouseDown() {
		float x, y;
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
		Vector2 worldPos = Camera.main.ScreenToWorldPoint (new Vector3(x, y, 0f));
		worldPos.x = Mathf.RoundToInt (worldPos.x);
		worldPos.y = Mathf.RoundToInt (worldPos.y);
		GameObject spawn = Instantiate (ButtonScript.selectedDefender, worldPos, Quaternion.identity) as GameObject;
		spawn.transform.parent = parent.transform;
	}
}