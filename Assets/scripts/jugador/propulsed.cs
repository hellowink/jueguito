using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propulsed : MonoBehaviour
{
    public float fuerzaPropulsion = 100f; // Fuerza de la propulsion

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si la colisión es con el airEnemy
        if (collision.gameObject.tag == "EnemyAir")
        {
            // Obtiene el componente Rigidbody del jugador
            Rigidbody rb = GetComponent<Rigidbody>();

            // Calcula la dirección de la propulsion (hacia atrás)
            Vector3 direccionPropulsion = -transform.forward;

            // Aplica la propulsion al jugador
            rb.AddForce(direccionPropulsion * fuerzaPropulsion, ForceMode.Impulse);
        }
    }
}
