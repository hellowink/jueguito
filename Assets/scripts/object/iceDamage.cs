using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class iceDamage : MonoBehaviour
{
    public 

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si la colisi�n es con el airEnemy
        if (collision.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene("youDied");
        } 
        
        
    }
}
