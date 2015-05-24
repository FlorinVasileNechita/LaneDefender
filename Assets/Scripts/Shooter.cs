using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile, projectileParent, spawnLocation;

	void Start () {
		if (!projectile) {
			Debug.LogError("Projectile not attached to " + name); 
		}
	}
	
	private void Fire() {
		GameObject newProjectile = Instantiate(projectile, spawnLocation.transform.position, Quaternion.identity) as GameObject;
		Debug.Log ("Spawning projectile " + projectile + " at " + spawnLocation.transform.position);
		newProjectile.transform.parent = projectileParent.transform;
	}
}
