using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {
	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolume(float volume) {
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError("Improper volume (range 0 to 1)");
		}
	}

	public static float GetMasterVolume() {
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel(int level) {
		if (level <= Application.levelCount - 1)
		{
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
		} 
		else
		{
			Debug.LogError ("Level " + level + " not found in build settings.");
		}
	}           

	public static bool GetUnlock(int level) {
		if (level <= Application.levelCount - 1) {
			int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString());
			if(levelValue == 1) {
				return true;
			}
			else { 
				return false;
			}
		} else {
			Debug.LogError("Level " + level + " does not exist!");
			return false;
		}
	}

	public static void SetDifficulty(int difficulty) {
		if (difficulty >= 1 && difficulty <= 3) {
			PlayerPrefs.SetInt(DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError("Difficulty should be 1 to 3");
		}
	}

	public static int GetDifficulty() {
		return PlayerPrefs.GetInt (DIFFICULTY_KEY);
	}
}
