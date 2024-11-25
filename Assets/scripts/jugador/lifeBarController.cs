using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class lifeBarController : MonoBehaviour
{
    public Image life;
    public float lifeActually = 10f;
    public float lifeMax = 10f;
    public float lifeMin = 0f;

    void Update()
    {
        life.fillAmount = lifeActually / lifeMax;

        if (lifeActually == lifeMin)
        {
            SceneManager.LoadScene("youDied");
        }
    }    
}
