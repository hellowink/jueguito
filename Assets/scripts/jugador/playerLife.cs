using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerLife : MonoBehaviour
{
    public int lifeMax = 10;
    public int lifeMin = 0;
    public int lifeActually = 10;

    public void GetDamage(int amount)
    {
        if (lifeActually <= lifeMin)
        {
            lifeActually = lifeMin;
            SceneManager.LoadScene("youDied");
        }
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
