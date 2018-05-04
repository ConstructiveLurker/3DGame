using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeWinLocation : MonoBehaviour 
{
	void Start () 
	{
		if (PlayerPrefs.GetString ("Difficulty") == "Easy") 
		{
			Vector3 position = new Vector3 (60.0f, 0.0f, 96.0f);
			gameObject.transform.position = position;
		}

		if (PlayerPrefs.GetString ("Difficulty") == "Normal") 
		{
			Vector3 position = new Vector3 (102.0f, 0.0f, 126.0f);
			gameObject.transform.position = position;
		}

		if (PlayerPrefs.GetString ("Difficulty") == "Hard") 
		{
			Vector3 position = new Vector3 (114.0f, 0.0f, 150.0f);
			gameObject.transform.position = position;
		}

	}
		
	void OnTriggerEnter (Collider collision)
	{
		if (collision.gameObject.name == "FPSController") 
		{
			SceneManager.LoadScene ("Game");
		}
	}
}
