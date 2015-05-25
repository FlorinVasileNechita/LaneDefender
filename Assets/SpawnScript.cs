using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] spawnList;

	void Update () {
		foreach (GameObject attacker in spawnList) {
			if(isTimeToSpawn(attacker)) {
				GameObject spawn = Instantiate(attacker) as GameObject;
				spawn.transform.position = transform.position;
				spawn.transform.parent = transform;
			}
		}
	}

	bool isTimeToSpawn(GameObject thisAttacker) {
		float threshold = (thisAttacker.GetComponent<Attacker> ().frequency) * Time.deltaTime; 
		// frequency in actual seconds.
		return (Random.value < threshold); // using random.value as a probability.
	}
}
