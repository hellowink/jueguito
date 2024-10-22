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
    public GameObject player;
    public GameObject esfera;


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
                // Cambia el mesh del player por el mesh de la esfera
                //rendererPlayer.enabled = !rendererPlayer.enabled;
                //rendererEsfera.enabled = !rendererfluffy.enabled;

                // Cambia el mesh del player
                //GetComponent<MeshFilter>().mesh = rendererPlayer.enabled ? meshCapsula : meshEsfera;
            }
        }



        

        

        
    }

    

}
