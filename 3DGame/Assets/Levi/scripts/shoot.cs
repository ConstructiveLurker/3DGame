using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public float damage = 10f;
    public Camera cam;
    public float range = 5f;
    public GameObject enemy;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("keypress O");
            Shoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            //ADS
            Debug.Log("ADS");
        }
    }
        void Shoot()
        {

            RaycastHit hit;
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
            {
                enemy interactable = hit.collider.GetComponent<enemy>();
                Debug.Log(hit.transform.name);
                if (enemy != null)
                {
                    var target = hit.transform.GetComponent<enemy>();
                    if (target != null)
                    {
                        target.TakeDamage(damage);

                    }
                }

            }
        }
    
}
     
    