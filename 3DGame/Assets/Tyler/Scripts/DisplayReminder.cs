using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayReminder : MonoBehaviour 
{	
	void Update () 
	{
		string reminder = PlayerPrefs.GetString ("NeedToDo");
		gameObject.GetComponent<TextMeshProUGUI> ().text = "" + reminder;
	}
}
