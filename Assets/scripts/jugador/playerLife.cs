using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class playerLife : MonoBehaviour
{
    

    public int lifeMax = 10;

    public int lifeMin = 0;

    public int lifeActually = 10;

    // Update is called once per frame
    void Update()
    {
        if (lifeActually<= lifeMin)
        {
            lifeActually = 0;

            Destroy(gameObject);

                
        }
    }
}
