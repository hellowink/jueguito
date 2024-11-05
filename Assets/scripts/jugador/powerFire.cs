using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerFire : MonoBehaviour
{
    public powerUpBar powerUpBar; // Referencia al script PowerUpBar
    public string paredHieloTag = "paredHielo"; // Tag de la paredHielo
    public eat eat;

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si la colisi�n es con la paredHielo
        if (collision.gameObject.tag == paredHieloTag)
        {
            // Verifica si la barra de poder est� llena
            if (eat.powerOfFire == true)
            {
                // Destruye la paredHielo
                Destroy(collision.gameObject);
            }
            else
            {
                // La barra de poder no est� llena, no se puede destruir la paredHielo
                Debug.Log("La barra de poder no est� llena");
            }
        }
    }
}
