using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarGravedad : MonoBehaviour
{
    public float gravedadAdicional = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.down * gravedadAdicional);
    }
}
