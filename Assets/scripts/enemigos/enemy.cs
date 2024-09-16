using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //protected int life;
    //protected float speed;
    //protected int damage;


    public GameObject bullet;  // Prefab de la bala
    public Transform firePoint;      // Punto desde el que se disparará la bala
    public float bulletSpeed = 10f;
    public float shootInterval = 2f; // Intervalo entre disparos
    private float shootTimer;        // Temporizador para controlar el intervalo de disparo

    private void Start()
    {
        shootTimer = shootInterval;  // Inicializar el temporizador
        Debug.LogWarning("bullet asignado: " + (bullet != null));
        Debug.LogWarning("firePoint asignado: " + (firePoint != null));
    }

    private void Update()
    {
        // Reducir el temporizador en cada frame
        shootTimer -= Time.deltaTime;

        Debug.Log("Tiempo restante para el próximo disparo: " + shootTimer);

        // Si el temporizador llega a cero, disparar la bala y reiniciar el temporizador
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

            // Configurar Rigidbody de la bala (si es necesario)
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
}
