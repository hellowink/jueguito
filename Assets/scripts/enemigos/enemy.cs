using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float life = 1f;

    public float velocidad = 5f; // Velocidad del enemigo
    public float rangoDeVision = 10f; // Rango de visión del enemigo
    private Transform player; // Referencia al jugador
    private bool playerEnRango = false; // Bandera para verificar si el jugador está en rango

    void Start()
    {
        // Busca el jugador en la escena
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Verifica si el jugador está en rango
        float distancia = Vector3.Distance(transform.position, player.position);
        playerEnRango = distancia <= rangoDeVision;

        // Si el jugador está en rango, persíguele
        if (playerEnRango)
        {
            PersigueJugador();
        }
    }

    void PersigueJugador()
    {
        // Calcula la dirección hacia el jugador
        Vector3 direccion = (player.position - transform.position).normalized;

        // Mueve el enemigo hacia el jugador
        transform.position += direccion * velocidad * Time.deltaTime;

        // Orienta el enemigo hacia el jugador
        transform.LookAt(player);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si colisionó con el jugador 
        if (collision.gameObject.tag == "Player")
        {
            // Ejecuta acción al colisionar con el jugador (por ejemplo, reducir salud)
            Debug.Log("Colisionó con el jugador");
        }
    }
}
