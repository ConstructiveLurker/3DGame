using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyList : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject[] list = GameObject.FindGameObjectsWithTag ("enemy");
		int enemiesLeft = list.Length;
		string enemy = enemiesLeft.ToString ();

		Debug.Log (list.Length);

		PlayerPrefs.SetString ("EnemyCount", enemy);
		if (list.Length == 0) 
		{
			SceneManager.LoadScene ("Game");
		}
	}
}
