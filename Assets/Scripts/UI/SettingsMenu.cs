using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
	int activeScreenQuaIndex =2;
	[SerializeField] AudioMixer mixer;

	ThirdPersonController controller;
	float temp = -80;
    private void OnEnable()
    {
		if (SceneManager.GetActiveScene().name == "MainMenu") return;
		Cursor.lockState = CursorLockMode.None;
		ThirdPersonController[] inputs = FindObjectsOfType<ThirdPersonController>();
		foreach (var item in inputs)
		{
			item.enabled = false;
		}


	}
	private void OnDisable()
    {
		if (SceneManager.GetActiveScene().name == "MainMenu") return;
		//Cursor.lockState = CursorLockMode.Locked;

		ThirdPersonController[] inputs = FindObjectsOfType<ThirdPersonController>();
		foreach (var item in inputs)
		{
			item.enabled = true;
		}


	}
	void Start()
	{
		controller = FindObjectOfType<ThirdPersonController>();
		activeScreenQuaIndex = PlayerPrefs.GetInt("qua");
		QualitySettings.SetQualityLevel(activeScreenQuaIndex);


		bool isFullscreen = (PlayerPrefs.GetInt("fullscreen") == 1) ? true : false;
		Screen.fullScreen = isFullscreen;
		
		mixer.SetFloat("Volume", PlayerPrefs.GetFloat("Vol"));
		//controller.FootstepAudioVolume = PlayerPrefs.GetFloat("Vol");
	}
	public void SetQuality(int i)
	{
		QualitySettings.SetQualityLevel(i);

		PlayerPrefs.SetInt("qua", i);
		PlayerPrefs.Save();

	}

	public void SetFullscreen(bool isFullscreen)
	{
		Screen.fullScreen = isFullscreen;

		PlayerPrefs.SetInt("fullscreen", ((isFullscreen) ? 1 : 0));
		PlayerPrefs.Save();
	}
	public void SetVolume(float vlo)
	{
		float f = Mathf.Lerp(-80, 0, vlo);
		mixer.SetFloat("Volume", f);
		controller.FootstepAudioVolume = vlo;
		PlayerPrefs.SetFloat("Vol", f);
		PlayerPrefs.Save();


	}
}
