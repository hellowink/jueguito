using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : enemy
{
    public int damage = 3;

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colisiona es el jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            playerLife playerLife = collision.gameObject.GetComponent<playerLife>();
            if (playerLife != null)
            {
                playerLife.GetDamage(damage);
                Debug.Log("El jugador ha recibido daño. Vida restante: " + playerLife.lifeActually);
            }
        }
    }
}
