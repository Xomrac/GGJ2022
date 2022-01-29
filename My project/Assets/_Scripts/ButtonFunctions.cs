using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour {
	private AudioMixer mixer;
	public GameObject SettingPannel;
	public void exitGame() {
		Application.Quit();
	}

	public void StartTimeTrial() {
		SceneManager.LoadScene(1);
	}

	public void volume(float slider) {
		mixer.SetFloat("Volume",slider);
	}

	public void OpenSetting() {
		SettingPannel.SetActive(!SettingPannel.activeSelf);
	}
}