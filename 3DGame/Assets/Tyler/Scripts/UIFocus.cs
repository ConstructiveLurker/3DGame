using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIFocus : MonoBehaviour 
{

	public GameObject canvasGroup;

	public GameObject button;

	float timer = 0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (EventSystem.current.currentSelectedGameObject == null &&)
		{
			if ()
			EventSystem.current.SetSelectedGameObject(button, new BaseEventData (EventSystem.current));
		}
	}
}
