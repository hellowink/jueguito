using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{

    public lifeBarController lifeBarController;
    public changeBall changeBall; 
    public powerUpBar powerUpBar; 
    public string enemyTag = "Enemy"; 
    public string enemyTagIce = "EnemyIce";
    public string bulletTag = "bullet";
    public bool niumNium= false;
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
        if (!changeBall.normalForm && collision.gameObject.tag == enemyTag )
        {
            powerUpBar.SumarPoder(2);
            Destroy(collision.gameObject); 
        }

        if (!changeBall.normalForm && collision.gameObject.tag == enemyTagIce)
        {
            powerUpBar.SumarPoder(2);
            Destroy(collision.gameObject); 
        }

        if (changeBall.normalForm && collision.gameObject.tag == enemyTag)
        {

            Debug.Log("recibiste 5 de daño");
            lifeBarController.lifeActually = lifeBarController.lifeActually - 5;
        }

        if (changeBall.normalForm && collision.gameObject.tag == enemyTagIce)
        {

            Debug.Log("recibiste 5 de daño");
            lifeBarController.lifeActually = lifeBarController.lifeActually - 5;
        }

        if (changeBall.normalForm && collision.gameObject.tag == "bullet")
        {

            Debug.Log("recibiste 2 de daño");
            lifeBarController.lifeActually = lifeBarController.lifeActually - 2;
        }

        if (!changeBall.normalForm && collision.gameObject.tag == "bullet")
        {

            Debug.Log("recibiste 2 de daño");
            lifeBarController.lifeActually = lifeBarController.lifeActually - 2;
        }


    }
}
