using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	void OnMouseDown() {
		float x, y;
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
		Vector2 worldPos = Camera.main.ScreenToWorldPoint (new Vector3(x, y, 0f));
		worldPos.x = Mathf.RoundToInt (worldPos.x);
		worldPos.y = Mathf.RoundToInt (worldPos.y);
		Instantiate (ButtonScript.selectedDefender, worldPos, Quaternion.identity);
	}
}