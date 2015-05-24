using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {
	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;
	private MusicManager musicManager;
	private float oldVolume;
	private int oldDifficulty;

	void Start () {
		musicManager = GameObject.FindObjectOfType <MusicManager>();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
		oldVolume = volumeSlider.value;
		oldDifficulty = (int) difficultySlider.value;
	}	

	public void ChangeVolume () {
		musicManager.ChangeVolume (volumeSlider.value);
	}

	public void SetDefaults() {
		volumeSlider.value = 1;
		difficultySlider.value = 2;
	}

	public void DiscardChanges() {
		volumeSlider.value = oldVolume;
		difficultySlider.value = oldDifficulty;
	}

	public void Apply() {
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty ((int) difficultySlider.value);
		levelManager.LoadLevel ("1 Main");
	}
}
