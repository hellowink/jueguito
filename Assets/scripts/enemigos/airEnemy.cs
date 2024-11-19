using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airEnemy : MonoBehaviour
{
    // Radio de visión para detectar al jugador
    public float radioVision = 10f;

    // Velocidad de movimiento del enemigo
    public float velocidadMovimiento = 5f;

    // Velocidad de disparo del enemigo
    public float velocidadDisparo = 10f;

    // Tiempo entre disparos
    public float tiempoEntreDisparos = 2f;

    // Referencia al jugador
    private Transform player;

    // Referencia al proyectil
    public GameObject bulletAir;

    private float tiempoUltimoDisparo = 0f;

    void Start()
    {
        // Busca el jugador en la escena
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Verifica si el jugador está dentro del radio de visión
        float distancia = Vector3.Distance(transform.position, player.position);
        if (distancia <= radioVision)
        {
            // Alejarse del jugador
            transform.position += (transform.position - player.position).normalized * velocidadMovimiento * Time.deltaTime;

            // Disparar hacia el jugador
            if (Time.time > tiempoUltimoDisparo + tiempoEntreDisparos)
            {
                tiempoUltimoDisparo = Time.time;
                Disparar();
            }
        }
    }

    void Disparar()
    {
        // Crea un nuevo proyectil
        GameObject proyectil = Instantiate(bulletAir, transform.position, transform.rotation);

        // Establece la velocidad del proyectil
        proyectil.GetComponent<Rigidbody>().velocity = (player.position - transform.position).normalized * velocidadDisparo;
    }
}
