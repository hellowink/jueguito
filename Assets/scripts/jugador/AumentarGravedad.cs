using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseGravity : MonoBehaviour
{
    public float additionalGravity = 100f;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rb.AddForce(Vector3.down * additionalGravity);
    }
}
