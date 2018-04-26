using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupObjects : MonoBehaviour {
    public float health = 1f;
    public float damage = 10f;
    public void TakeDamage(float amount)
    {
        Debug.Log("taco");
        health -= damage;
    }
    void Update()
    {
        if (health <= 0f)
        {
          //add item to inventory
            Destroy(gameObject);
        }
    }   
    

  

}
