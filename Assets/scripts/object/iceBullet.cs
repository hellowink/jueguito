using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceBullet : MonoBehaviour
{
    public playerMovement playerMovement;
    


    void OnCollisionEnter(Collision collision)
    {
        



        if (collision.gameObject.tag == "Player")
        {
            playerMovement playerMovement = collision.gameObject.GetComponent<playerMovement>();
            playerMovement.SlowDown();                            
            Destroy(gameObject);
            
            
        }

        
    }

    /*public void Freeze()
    {
        // Verifica si los materiales están configurados
        if (materialOriginal == null || materialIce == null)
        {
            Debug.LogError("Materiales no configurados");
            return;
        }

        // Cambia el material a icewall
        GetComponent<Renderer>().material = materialIce;

        // Espera 1 segundo
        Invoke("Unfreeze", 1f);


    }
    */

   

    

    


}
