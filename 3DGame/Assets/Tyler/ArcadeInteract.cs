using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ArcadeInteract : MonoBehaviour {

	public GameObject maze;
	public GameObject gameUI;

	public GameObject mazeButton;

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButton ("select"))
		{
			RaycastHit hit;
			Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

			if (Physics.Raycast (ray, out hit))
			{
				if (hit.collider != null && hit.collider.gameObject.name == ("Maze")) 
				{
					maze.SetActive (true);
					EventSystem.current.SetSelectedGameObject (mazeButton, new BaseEventData (EventSystem.current));
				}

				if (hit.collider != null && hit.collider.gameObject.name == ("Shooter")) 
				{
					SceneManager.LoadScene ("Shooter");	
				}

				if (hit.collider != null && hit.collider.gameObject.name == ("CaptureTheFlag")) 
				{
					SceneManager.LoadScene ("CaptureTheFlag");
				}
			}
		}
	}
}