using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayReminder : MonoBehaviour 
{	
	void Start ()
	{
		gameObject.GetComponent<TextMeshProUGUI> ().text = "";
	}

	void Update () 
	{
		string reminder = PlayerPrefs.GetString ("NeedToDo");
		gameObject.GetComponent<TextMeshProUGUI> ().text = "" + reminder;
	}
}
