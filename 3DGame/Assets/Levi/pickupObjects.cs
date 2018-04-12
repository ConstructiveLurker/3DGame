using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupObjects : MonoBehaviour {
    public float health = 1f;
    public void TakeDamage(float ammount)
    {
        Debug.Log("taco");
        health -= ammount;
        if(health <= 0f)
        {
            die();
        }
    }

    void die()
    {
        Destroy(gameObject);
    }

}
