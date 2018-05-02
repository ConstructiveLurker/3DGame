using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastForInteract : MonoBehaviour
{
    public float damage = 10f;
    public Camera cam;
    public float range = 5f;
    void Update()
    {
        if (Input.GetButtonDown("select"))
        {
            //Debug.Log("keypress O");
            Shoot();
        }
     
        
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            interactable1 interactable = hit.collider.GetComponent<interactable1>();
            //Debug.Log("Shoost");
            if (interactable != null)
            {
                var target = hit.transform.GetComponent<pickupObjects>();
                if (target != null)
                {
                    target.TakeDamage(damage);

                }
            }
            door door = hit.collider.GetComponent<door>();
            if(door != null)
            {
                //open door
            }

        }


    }
}
