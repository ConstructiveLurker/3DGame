using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public float health = 50f;
    public float damage = 25f;
    public float range = 5f;
    public GameObject player;
    public void TakeDamage(float amount)
    {
        //Debug.Log("yes");
        health -= amount;

        if (health <= 0f)
        {
            Die();
        }
    }
	void Die()
    {
        Destroy(gameObject);
    }
}
