using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastForInteract : MonoBehaviour
{
    public float damage = 10f;
    public Camera cam;
    public float range = 3f;
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
            //Debug.Log("Shoost");
              var target = hit.transform.GetComponent<pickupObjects>();
                if(target!=null)
                {
                target.TakeDamage(damage);

                }
        }


    }
}
