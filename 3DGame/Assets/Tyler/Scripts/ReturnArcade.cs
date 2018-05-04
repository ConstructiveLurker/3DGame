using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnArcade : MonoBehaviour 
{

	public void Return () 
	{
		SceneManager.LoadScene ("Game");
	}

}
