﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class pause : MonoBehaviour 
{

    public int number;

	public GameObject pauseCanvas;
	public GameObject gameCanvas;

	public GameObject button;

    // Update is called once per frame
    void Update()
	{
        //if we press escape or p, we should pause
		if (Input.GetButtonDown("Save"))
        {
            Time.timeScale = 0;
            //assume this script is attached to 
            //pause menu canvas
			pauseCanvas.SetActive(true);
			gameCanvas.SetActive (false);

			EventSystem.current.SetSelectedGameObject (button, new BaseEventData (EventSystem.current));
		}
	}

    public void Resume()
    {
        //reset the timescale to 1, and hide the canvas
        Time.timeScale = 1;
		pauseCanvas.SetActive (false);
		gameCanvas.SetActive (true);
    }
    public void QuitGame()
    {
        //this will stop the .ExecuteInEditMode Application from running after the game has been built
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
