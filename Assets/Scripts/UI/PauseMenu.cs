using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	private void OnEnable()
	{
		Time.timeScale = 0;
		Cursor.lockState = CursorLockMode.None;
		StarterAssetsInputs[] inputs = FindObjectsOfType<StarterAssetsInputs>();
        foreach (var item in inputs)
        {
			item.cursorInputForLook = false;
			Vector2 zero = new Vector2(0, 0);
			item.LookInput(zero);
        }

	}
	private void OnDisable()
	{
		Time.timeScale = 1;
		StarterAssetsInputs[] inputs = FindObjectsOfType<StarterAssetsInputs>();
		foreach (var item in inputs)
		{
			item.cursorInputForLook = true;
			Cursor.lockState = CursorLockMode.Locked;
		}

	}
	public void Resume()
    {
        gameObject.SetActive(false);
    }

    public void QuitGame()
    {

        Application.Quit();
    }
}
