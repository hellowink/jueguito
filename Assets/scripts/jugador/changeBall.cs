using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBall : MonoBehaviour
{

    public playerMovement playerMovement;

    public pastilla pastilla;

    public bool normalForm = true;

    public GameObject esfera; // Asigna el objeto de la esfera en el inspector


    public Renderer rendererPlayer; // Referencia al renderer del player


    void Start()
    {




    }

    void Update()
    {
        // Cuando se presiona la tecla Q
        if (Input.GetKeyDown(KeyCode.Q))
        {

            if (pastilla.grajea == true)
            {
                

                // Cambia el mesh del player por el mesh de la esfera
                rendererPlayer.enabled = !rendererPlayer.enabled;

                esfera.SetActive(!esfera.activeSelf);

                normalForm = !normalForm;
            }

            

        }
    }

}
