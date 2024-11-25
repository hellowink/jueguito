using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice : enemy
{
    public GameObject bullet;  
    public Transform firePoint;    
    public float bulletSpeed = 10f;
    public float shootInterval = 2f; 
    private float _shootTimer;       

    private void Start()
    {
        _shootTimer = shootInterval;  
    }

    private void Update()
    {
        _shootTimer -= Time.deltaTime;

        if (_shootTimer <= 0f)
        {
            Shoot();
            _shootTimer = shootInterval;
        }
    }

    void Shoot()
    {
        if (bullet != null && firePoint != null)
        {
            GameObject bulletInstance = Instantiate(bullet, firePoint.position, firePoint.rotation);

            Rigidbody rb = bulletInstance.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.useGravity = false;
                rb.velocity = firePoint.forward * bulletSpeed;
            }
        }
    }
}
