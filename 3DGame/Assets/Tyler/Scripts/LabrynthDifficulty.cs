using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LabrynthDifficulty : MonoBehaviour 
{
	public void Easy ()
	{
		SceneManager.LoadScene ("Sandbox");

		PlayerPrefs.SetInt ("Length", 12);
		PlayerPrefs.SetInt ("Width", 12);
	}

	public void Normal ()
	{
		SceneManager.LoadScene ("Sandbox");

		PlayerPrefs.SetInt ("Length", 12);
		PlayerPrefs.SetInt ("Width", 18);
	}

	public void Hard ()
	{
		SceneManager.LoadScene ("Maze");

		PlayerPrefs.SetInt ("Length", 18);
		PlayerPrefs.SetInt ("Width", 18);
	}
}
