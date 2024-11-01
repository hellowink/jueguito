using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{

    public playerLife playerLife;
    public changeBall changeBall; // Referencia al script ChangeForm
    public powerUpBar powerUpBar; // Referencia al script PowerUpBar
    public string enemyTag = "Enemy"; // Tag de los enemigos
    public bool niumNium= false;

    

    // Update is called once per frame
    void Update()
    {
        if (powerUpBar.powerActually >= powerUpBar.powerMax)
        {
            niumNium = true;
        }
        else
        {
            niumNium = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!changeBall.normalForm && collision.gameObject.tag == enemyTag)
        {
            powerUpBar.SumarPoder(2);
            Destroy(collision.gameObject); // Opcional: Destruir al enemigo despu�s de la colisi�n
        }

        if (changeBall.normalForm && collision.gameObject.tag == enemyTag)
        {

            Debug.Log("recibiste 5 de da�o");
            playerLife.lifeActually = playerLife.lifeActually - 5;
        }
    }
}