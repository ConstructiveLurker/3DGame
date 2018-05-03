using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public float damage = 25f;
    public Camera FirstPersonCharacter;
    public Camera ADSCam;
    public float range = 5f;
    public bool cam = true;
    public bool ADS = false;
    public float ADSMOD = 2f;
    void Update()
    {
        if (cam == true)
        {
            FirstPersonCharacter.enabled = true;
            ADSCam.enabled = false;
        }
        else if(cam == false)
        {
            FirstPersonCharacter.enabled = false;
            ADSCam.enabled = true;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("keypress O");
            Shoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            ADS = true;
            cam = false; 
            //ADS
            Debug.Log("ADS");
        }
        else if(Input.GetButtonUp("Fire2"))
        {
            ADS = false;
            cam = true;
        }
    }
        void Shoot()
        {
            
            RaycastHit hit;
        if (ADS == true)
        {
            if (Physics.Raycast(ADSCam.transform.position, ADSCam.transform.forward, out hit, range))
            {

                enemy interactable = hit.collider.GetComponent<enemy>();
                Debug.Log(hit.transform.name);
                if (gameObject.tag == "enemy")
                {
                    var enemy = hit.transform.GetComponent<enemy>();
                    if (enemy != null)
                    {
                        enemy.TakeDamage(damage);

                    }
                }


            }
        }
        if (Physics.Raycast(FirstPersonCharacter.transform.position, FirstPersonCharacter.transform.forward, out hit, range ))
            {
                enemy interactable = hit.collider.GetComponent<enemy>();
                Debug.Log(hit.transform.name);
                if (gameObject.tag == "enemy" )
                {
                    var enemy = hit.transform.GetComponent<enemy>();
                 if (enemy != null)
                    {
                        enemy.TakeDamage(damage);

                    }
                }
            
            }
        }
   
  
}
     
    