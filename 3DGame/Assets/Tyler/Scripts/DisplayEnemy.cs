using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayEnemy : MonoBehaviour 
{

	string enemies;
	void Start () 
	{
		string enemies = PlayerPrefs.GetString ("EnemyCount");
		gameObject.GetComponent<TextMeshProUGUI> ().text = "Enemies left: " + enemies;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (PlayerPrefs.GetString ("EnemyCount"));

		string enemies = PlayerPrefs.GetString ("EnemyCount");
		gameObject.GetComponent<TextMeshProUGUI> ().text = "Enemies left: " + enemies;
	}
}
