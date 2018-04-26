using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactable1 : MonoBehaviour
{
    public float radius = 3f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radius);

    }

}
