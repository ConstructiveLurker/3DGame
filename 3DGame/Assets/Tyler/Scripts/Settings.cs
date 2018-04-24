using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class Settings : MonoBehaviour 
{

	public AudioMixer audioMixer;

	public TMP_Dropdown resolutionDropdown;

	public TMP_Dropdown graphicsDropdown;

	Resolution[] resolutions;

	void Start ()
	{
		resolutions = Screen.resolutions;

		resolutionDropdown.ClearOptions ();

		List <string> options = new List <string> ();

		int currentResolutionIndex = 0;

		for (int i = 0; i < resolutions.Length; i++) 
		{
			string option = resolutions[i].width + " x " + resolutions[i].height;
			options.Add (option);

			if (resolutions [i].width == Screen.currentResolution.width && 
				resolutions [i].height == Screen.currentResolution.height) 
			{
				currentResolutionIndex = i;
			}
		}

		resolutionDropdown.AddOptions (options);
		resolutionDropdown.value = currentResolutionIndex;
		resolutionDropdown.RefreshShownValue();
		graphicsDropdown.RefreshShownValue ();
	}

	// go to Edit > Project Settings > Player > Resolution and Presentation > 
	// Standalone Player Options > then set the Display Resolution Dialogue to disabled
	// ***this gets rid of the initial resolution select window upon starting the game

	public void SetResolution (int resolutionIndex)
	{
		Resolution resolution = resolutions [resolutionIndex];
		Screen.SetResolution (resolution.width, resolution.height, Screen.fullScreen);
	}

	public void SetVolume (float volume)
	{
		audioMixer.SetFloat ("Volume", volume);
	}

	public void SetGraphicsQuality (int qualityIndex)
	{
		QualitySettings.SetQualityLevel (qualityIndex);
	}
		
	public void SetFullscreen (bool isFullscreen)
	{
		Screen.fullScreen = isFullscreen;
	}
}
