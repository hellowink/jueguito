using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampa : MonoBehaviour
{
    public static event System.Action ActivarEvento;

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el jugador colisionó con la trampa
        if (collision.gameObject.CompareTag("Player"))
        {
            // Llama al evento para que los objetos con tag "picks" caigan
            ActivarEvento?.Invoke();
        }
    }



}
