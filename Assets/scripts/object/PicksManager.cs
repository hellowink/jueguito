using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicksManager : MonoBehaviour
{
    void OnEnable()
    {
        trampa.ActivarEvento += ActivarEventoPicks;
    }

    void OnDisable()
    {
        trampa.ActivarEvento -= ActivarEventoPicks;
    }

    void ActivarEventoPicks()
    {
        // Obtiene todos los objetos con tag "picks"
        GameObject[] picks = GameObject.FindGameObjectsWithTag("pick");

        // Recorre cada objeto y aplica la fuerza de gravedad
        foreach (GameObject pick in picks)
        {
            // Agrega un Rigidbody si no lo tiene
            if (!pick.GetComponent<Rigidbody>())
            {
                pick.AddComponent<Rigidbody>();
            }

            // Aplica la fuerza de gravedad
            pick.GetComponent<Rigidbody>().useGravity = true;

            // Destruye el objeto al colisionar con algo
            pick.AddComponent<DestroyOnCollision>();
        }
    }

    public class DestroyOnCollision : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision)
        {
            // Destruye el objeto
            Destroy(gameObject);
        }
    }
}
