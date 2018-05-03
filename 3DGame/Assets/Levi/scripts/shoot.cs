using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float health = 50f;
    public float damage = 25f;
    public Camera FirstPersonCharacter;
    public Camera ADSCam;
    public float range = 5f;
    public bool cam = true;
    public bool ADS = false;
    public float ADSMOD = 2f;
    public GameObject Gun1;
    public GameObject Gun2;
    private void Start()
    {
        FirstPersonCharacter.enabled = true;
        ADSCam.enabled = false;
        Gun1.SetActive(true);
        Gun2.SetActive(false);
    }
    void Update()

    {
      if (Input.GetButtonDown("Fire1"))
            {
            Shoot();
        }
       /* if (cam == true)
        {
            FirstPersonCharacter.enabled = true;
            ADSCam.enabled = false;
            Gun1.SetActive(true);
            Gun2.SetActive(false);
        }
        else if(cam == false)
        {
            FirstPersonCharacter.enabled = false;
            ADSCam.enabled = true;
            Gun1.SetActive(false);
            Gun2.SetActive(true);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("keypress O");
            Shoot();
        }*/
        if (Input.GetButtonDown("Fire2"))
        {
            FirstPersonCharacter.enabled = false;
            ADSCam.enabled = true;
            Gun1.SetActive(false);
            Gun2.SetActive(true);
            //ADS
            Debug.Log("ADS");
            ADS = true; 
        }
        else if(Input.GetButtonUp("Fire2"))
        {
            FirstPersonCharacter.enabled = true;
            ADSCam.enabled = false;
            Gun1.SetActive(true);
            Gun2.SetActive(false);
            ADS = false;
        }
    }
        void Shoot()
        {
            
            RaycastHit hit;
        Debug.Log(ADS);
        if (ADS == true)
        {
            if (Physics.Raycast(ADSCam.transform.position, ADSCam.transform.forward, out hit, range))
            {

                enemy interactable = hit.collider.GetComponent<enemy>();
                Debug.Log(hit.transform.name);
               
                    var enemy = hit.collider.gameObject.GetComponent<enemy>();
                    if (enemy != null)
                    {
                        enemy.TakeDamage(damage);

                    }
                


            }
        }
        else if (Physics.Raycast(FirstPersonCharacter.transform.position, FirstPersonCharacter.transform.forward, out hit, range ))
            {
                enemy interactable = hit.collider.GetComponent<enemy>();
                //Debug.Log(hit.transform.name);
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
     
    