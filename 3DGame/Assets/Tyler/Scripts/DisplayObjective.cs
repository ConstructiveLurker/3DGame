using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DisplayObjective : MonoBehaviour 
{
	string objective;

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Scene currentScene = SceneManager.GetActiveScene ();
		string sceneName = currentScene.name;

		if (sceneName == "Game") 
		{
			objective = "Mom said you can be here until closing. Time to play some games and earn prizes.";
		}

		if (sceneName == "Sandbox") 
		{
			objective = "Find the end of the maze.";
		}

		if (sceneName == "FPS") 
		{
			objective = "Kill all enemies.";
		}

		if (sceneName == "CaptureTheFlag") 
		{
			objective = "Capture the flag.";
		}

		if (sceneName == "CaptureTheFlag") 
		{
			objective = "Return the flag to your base.";
		}

		gameObject.GetComponent<TextMeshProUGUI> ().text = "OBJECTIVE: " + objective; 
	}
}
