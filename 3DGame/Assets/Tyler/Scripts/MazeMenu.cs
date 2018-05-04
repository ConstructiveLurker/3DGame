using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeMenu : MonoBehaviour 
{
	void start ()
	{
		gameObject.SetActive (false);
	}

	public void Easy ()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene ("Sandbox");

		PlayerPrefs.SetInt ("Length", 18);
		PlayerPrefs.SetInt ("Width", 12);

		PlayerPrefs.SetString ("Difficulty", "Easy");
	}

	public void Normal ()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene ("Sandbox");

		PlayerPrefs.SetInt ("Length", 22);
		PlayerPrefs.SetInt ("Width", 18);

		PlayerPrefs.SetString ("Difficulty", "Normal");
	}

	public void Hard ()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene ("Sandbox");

		PlayerPrefs.SetInt ("Length", 26);
		PlayerPrefs.SetInt ("Width", 22);

		PlayerPrefs.SetString ("Difficulty", "Hard");
	}

	public void Exit ()
	{
		gameObject.SetActive (false);
	}
}
