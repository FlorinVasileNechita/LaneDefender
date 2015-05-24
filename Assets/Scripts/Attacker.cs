using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	private float walkSpeed;

	// Use this for initialization
	void Start () {
		Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D> ();
		rb.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * walkSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D col) {
		Debug.Log (col + " triggered a collision with " + name);
	}

	public void SetSpeed(float speed) {
		walkSpeed = speed;
	}

	public void StrikeCurrentTarget(float damage) {
		Debug.Log (name + " did " + damage + " damage!");
	}
}
