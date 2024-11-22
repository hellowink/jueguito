using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerIce : MonoBehaviour
{
    public powerUpBar powerUpBar; // Referencia al script PowerUpBar
    public string aguita = "agua"; // Tag de la paredHielo
    public eat eat;

    

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si la colisión es con la paredHielo
        if (other.gameObject.tag == "agua")
        {
            // Verifica si la barra de poder está llena
            if (eat.powerOfFire == true)
            {
                // congela el aguita
                Collider aguaCollider = other.gameObject.GetComponent<Collider>();

                aguaCollider.isTrigger = false;
            }
            else
            {
                // La barra de poder no está llena, no se puede destruir la paredHielo
                Debug.Log("La barra de poder no está llena");
            }
        }
    }

}
