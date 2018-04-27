using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIFocus : MonoBehaviour 
{

	public GameObject canvasGroup1;
	public GameObject canvasGroup2;

	public GameObject button1;
	public GameObject button2;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (EventSystem.current.currentSelectedGameObject == null)
		{
			
			if (canvasGroup1.activeSelf) 
			{
				EventSystem.current.SetSelectedGameObject (button1, new BaseEventData (EventSystem.current));
			}

			if (canvasGroup2.activeSelf) 
			{
				EventSystem.current.SetSelectedGameObject (button2, new BaseEventData (EventSystem.current));
			}
		}
	}
}
