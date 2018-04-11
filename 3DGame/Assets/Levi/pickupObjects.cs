using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupObjects : MonoBehaviour {
    bool iscarryable = false;
    bool isgame = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("submit"))
        { //activate or pickup object
            if (iscarryable)
            {
                Destroy(gameObject);  
            }
            else if(isgame)
            {
                //load scene for the game being interacted with.
            }
           
                    }

        }
}
