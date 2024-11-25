using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propulsed : MonoBehaviour
{
    public float forcePropulsion = 100f; 

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyAir")
        {
            Rigidbody rb = GetComponent<Rigidbody>();

            Vector3 directionPropulsion = -transform.forward;

            rb.AddForce(directionPropulsion * forcePropulsion, ForceMode.Impulse);
        }
    }
}
