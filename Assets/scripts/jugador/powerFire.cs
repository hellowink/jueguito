using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerFire : MonoBehaviour
{
    public powerUpBar powerUpBar; 
    public string tagIceWall = "paredHielo"; 
    public eat eat;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == tagIceWall)
        {
            if (eat.powerOfFire == true)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
