using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastForInteract : MonoBehaviour {
    public Camera cam;
    public float range = 3f;
    void Update()
    {
         if(Input.GetButtonDown("select"))
        {
            Debug.Log("keypress O");
            Shoot();
        }
       
    }
    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward,out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
   
                }
}
