using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile, spawnLocation;
	private GameObject projectileParent;
	void Start () {

		projectileParent = GameObject.Find ("Projectiles");

		if (!projectileParent) {
			projectileParent = new GameObject("Projectiles");
		}
	}
	
	private void Fire() {
		GameObject newProjectile = Instantiate(projectile, spawnLocation.transform.position, Quaternion.identity) as GameObject;
		Debug.Log ("Spawning projectile " + projectile + " at " + spawnLocation.transform.position);
		newProjectile.transform.parent = projectileParent.transform;
	}
}
