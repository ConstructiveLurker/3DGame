using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoost : MonoBehaviour
{
    public GameObject prefab;
    public float bulletSpeed = 10f;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 1.0f;
    private float timer = 0;
    // Use this for initialization
    void Start()
    {
        timer = shootDelay;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && timer >= shootDelay)
        {
            //get the mouse position
            var mousePosition = Input.mousePosition;
            //convert the mouse position from pixels to x,y values in the game
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //create the shoot direction, which is calculated by mousePosition - playerPosition
            Vector3 shootDirection = new Vector3(mousePosition.x - transform.position.x,0.1f, mousePosition.z - transform.position.z);// mousePosition.z - transform.position.z);
            //create the bullet object

            //reduce the length of the direction to 1, so it is always the same regardless of how far away
            //the mouse is from the player. 
            shootDirection.Normalize();

            Vector3 spawnPosition = transform.position;
            spawnPosition.x += shootDirection.x * 0.2f;
            //spawnPosition.y += shootDirection.y * 0.2f;
            spawnPosition.z += shootDirection.z * 0.2f;
            //create the object in front of the player
            GameObject bullet = (GameObject)Instantiate(prefab, spawnPosition, Quaternion.identity);
            //apply the velocity in the shoot direction
            bullet.GetComponent<Rigidbody>().velocity = shootDirection * bulletSpeed;
            Destroy(bullet, bulletLifetime);
            timer = 0;
        }
    }
}