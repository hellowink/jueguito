using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBall : MonoBehaviour
{

    public playerMovement playerMovement;

    public pastilla pill;

    public bool normalForm = true;

    public GameObject esfera; 


    public Renderer rendererPlayer; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (pill.grajea)
            {
                Morph();
                playerMovement.speed = 15;              
            }
        }

        if (!pill.grajea && !rendererPlayer.enabled )
        {
            Morph();
            playerMovement.speed = 10;
        }

        if (Input.GetKeyDown(KeyCode.Q) && rendererPlayer.enabled)
        {
            
            playerMovement.speed = 10;
        }
    }

    public void Morph()
    {
        rendererPlayer.enabled = !rendererPlayer.enabled;

        esfera.SetActive(!esfera.activeSelf);

        normalForm = !normalForm;
    }

}
