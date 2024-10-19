using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class changeForm : MonoBehaviour
{
    public Mesh meshCapsula; // Mesh de la cápsula
    public Mesh meshEsfera; // Mesh de la esfera
    private MeshFilter meshFilter; // Referencia al MeshFilter
    public bool normalForm = true; // Bandera para saber si es cápsula o esfera
    public playerMovement playerMovement; // Referencia al script PlayerMovement
    public pastilla pastilla; //referencia al script pastilla



    void Start()
    {

        
        meshFilter = GetComponent<MeshFilter>(); // Obtiene el MeshFilter
        playerMovement = GetComponent<playerMovement>(); // Obtiene el script PlayerMovement
        pastilla = GetComponent<pastilla>(); //referencia al script pastilla
    }

    void Update()
    {
        if (pastilla.grajea) //si la variable grajea del script pastilla es true..
        {
            if (Input.GetKeyDown(KeyCode.Q)) // Si se presiona la tecla Q
            {
                // Cambia el mesh del MeshFilter
                if ( normalForm)
                {
                    meshFilter.mesh = meshEsfera;
                    normalForm = false;
                    playerMovement.speed = 20f; // Aumenta la velocidad cuando es esfera
                }
                else
                {
                    meshFilter.mesh = meshCapsula;
                    normalForm = true;
                    playerMovement.speed = 10f; // Restablece la velocidad cuando es cápsula
                }
            }
        }



        

        

        
    }

    

}
