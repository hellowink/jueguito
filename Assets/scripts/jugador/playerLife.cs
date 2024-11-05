using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerLife : MonoBehaviour
{
    public int lifeMax = 10;

    public int lifeMin = 0;

    public int lifeActually = 10;


    // Update is called once per frame
    public void GetDamage(int cantidad)
    {
        /*lifeActually -= cantidad;*/

        if (lifeActually <= lifeMin)
        {
            lifeActually = lifeMin;
            Debug.Log("¡El jugador ha muerto!");
            SceneManager.LoadScene("youDied");

        }

        Debug.Log("Vida restante: " + lifeActually);
    }

    void Update()
    {
        if (lifeActually <= lifeMin)
        {
            lifeActually = 0;
        }

        GetDamage(lifeActually);
    }
}
