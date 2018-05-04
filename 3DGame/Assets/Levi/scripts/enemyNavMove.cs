using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class enemyNavMove : MonoBehaviour
{
    NavMeshAgent agent;
    public float health = 50f;
    public float damage = 25f;
    public float range = 5f;
    public Transform playerTransform;
    public GameObject Player;
    public float chaseTriggerDistance = 10.0f;
    private Vector3 startPosition;
    private bool home = true;
    private Vector3 homeDirection;
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
    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update() {
        RaycastHit hit;
        Vector2 chaseDirection = playerTransform.position - transform.position;
        if (chaseDirection.magnitude < chaseTriggerDistance)
        {
            agent.destination = playerTransform.position;
            home = false;
            if (Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, range))
            {

                Player = hit.collider.gameObject.GetComponent<shoot>();
                Debug.Log(hit.transform.name);

                var enemy = hit.collider.gameObject.GetComponent<enemyNavMove>();
                if (enemy != null)
                {
                    enemy.TakeDamage(damage);

                }
            }
            else if (!home)
            {
                agent.destination = startPosition;
                Vector3 homeDirection = startPosition - transform.position;
                if (homeDirection.magnitude <= 0.03f)
                {
                    home = true;
                    Debug.Log("foo");
                }


            }
        }

    }
}
