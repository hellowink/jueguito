using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class changeForm : MonoBehaviour
{
     public Mesh meshCapsula; // Mesh de la cápsula
    public Mesh meshEsfera; // Mesh de la esfera
    private MeshFilter playermeshFilter; // Referencia al MeshFilter
    public bool esCapsula = true; // Bandera para saber si es cápsula o esfera
    public playerMovement playerMovement; // Referencia al script PlayerMovement
    public pastilla pastilla; //referencia al script pastilla
    public GameObject playermesh;



    void Start()
    {
        if (playermesh != null)
        {
            playermeshFilter = playermesh.GetComponent<MeshFilter>();
        }

        //playermeshFilter = GetComponent<MeshFilter>(); // Obtiene el MeshFilter
        playerMovement = GetComponent<playerMovement>(); // Obtiene el script PlayerMovement
        pastilla = GetComponent<pastilla>(); //referencia al script pastilla
    }

    void Update()
    {
        if (playermeshFilter != null) // Asegurarse de que playermeshFilter no sea nulo
        {
            if (pastilla.grajea) //si la variable grajea del script pastilla es true..
            {
                if (Input.GetKeyDown(KeyCode.Q)) // Si se presiona la tecla Q
                {
                    // Cambia el mesh del MeshFilter
                    if (esCapsula)
                    {
                        playermeshFilter.mesh = meshEsfera;
                        esCapsula = false;
                        playerMovement.speed = 20f; // Aumenta la velocidad cuando es esfera
                    }
                    else
                    {
                        playermeshFilter.mesh = meshCapsula;
                        esCapsula = true;
                        playerMovement.speed = 10f; // Restablece la velocidad cuando es cápsula
                    }
                }
            }





        }

        
    }

    

}
