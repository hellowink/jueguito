using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject bullet;
    public float shootInterval = 5f;
    public float bulletSpeed = 10f;
    public float bulletLifeTime = 2.0f;
    private float shootTimer;
    public Transform player;
    public Transform firePoint;

    private void Start()
    {
        shootTimer = shootInterval;
    }

    void Update() //CALCULA EL TIEMPO PARA QUE SE VUELVA A DISPARAR OTRA BALA
    {
        shootTimer -= Time.deltaTime;
        if (shootTimer <= 0f)
        {
            Shoot();
            shootTimer = shootInterval;
        }
    }

    void Shoot()
    {

        if (bullet != null && firePoint != null)
        {
            // Instanciar la bala en la posición y rotación del firePoint
            GameObject bulletInstance = Instantiate(bullet, firePoint.position, firePoint.rotation);
            Debug.Log("Bala instanciada en: " + firePoint.position);

            // Configurar Rigidbody de la bala
            Rigidbody rb = bulletInstance.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.useGravity = false;
                rb.velocity = firePoint.forward * bulletSpeed;
                Debug.Log("Velocidad de la bala: " + rb.velocity);
            }
            else
            {
                Debug.LogWarning("No se encontró un Rigidbody en la bala instanciada.");
            }
        }
        else
        {
            Debug.LogWarning("bulletPrefab o firePoint no están asignados.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("La bala ha golpeado al jugador");

            // Aquí puedes realizar la acción deseada, como hacer daño al jugador
            // Ejemplo: other.GetComponent<PlayerHealth>().TakeDamage(damageAmount);

           Destroy(gameObject);  // Destruir la bala después de la colisión
        }
        else
        {
            Debug.Log("La bala no colisionó con el jugador");
        }
    }

}

