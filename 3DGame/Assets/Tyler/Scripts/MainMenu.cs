using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour 
{
	public GameObject mainMenu;

	public GameObject settings;

	void Update ()
	{
		/*
		if (EventSystem.current == null) 
		{
			EventSystem.current.SetSelectedGameObject(mainMenu, new BaseEventData (EventSystem.current));
		}
		*/
	}

	public void Play ()
	{
		SceneManager.LoadScene ("Game");
	}

	public void Settings ()
	{
		EventSystem.current.SetSelectedGameObject(settings, new BaseEventData (EventSystem.current));
	}

	public void Quit ()
	{
		Application.Quit ();
	}
}
