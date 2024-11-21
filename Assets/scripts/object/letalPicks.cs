using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class letalPicks : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Verifica si la colisi�n es con el jugador
        if (collision.gameObject.tag == "Player")
        {
            // Carga la escena MenuInicial
            SceneManager.LoadScene("MenuInicial");
        }
    }
    
}
