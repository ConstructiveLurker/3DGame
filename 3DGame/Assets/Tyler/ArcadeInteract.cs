using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ArcadeInteract : MonoBehaviour {

	public GameObject maze;
	public GameObject gameUI;

	public GameObject mazeButton;

	private float timer;

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown ("select") || Input.GetButton ("Fire1"))
		{
			RaycastHit hit;
			Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

			Debug.Log ("1");

			if (Physics.Raycast (ray, out hit))
			{
				Debug.Log ("2");
				Debug.Log (hit.collider.gameObject.name);

				if (hit.collider != null && hit.collider.gameObject.name == ("Maze")) 
				{
					Time.timeScale = 0;
					maze.SetActive (true);
					gameUI.SetActive (false);
					EventSystem.current.SetSelectedGameObject (mazeButton, new BaseEventData (EventSystem.current));
					GameObject.Find ("FPSController").GetComponent<save> ().Save ();
					Debug.Log ("3");
				}

				if (hit.collider != null && hit.collider.gameObject.name == ("Shooter")) {
					if (PlayerPrefs.GetInt ("Progress") == 1) {
						GameObject.Find ("FPSController").GetComponent<save> ().Save ();
						SceneManager.LoadScene ("FPS");
					} else {
						PlayerPrefs.SetString ("NeedToDo", "You need to beat the maze before you can play the shooter.");
					}
				}

				if (hit.collider != null && hit.collider.gameObject.name == ("CaptureTheFlag")) 
				{
					PlayerPrefs.SetString ("NeedToDo", "This game appears to be Out of Order.");
					//SceneManager.LoadScene ("CaptureTheFlag");
				}
			}
		}
		timer += Time.deltaTime; 
		if (timer >= 3) {
			PlayerPrefs.SetString ("NeedToDo", " ");
			timer = 0f;
		}
	}
}