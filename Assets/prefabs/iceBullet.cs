using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerMovement playerMovement = collision.gameObject.GetComponent<playerMovement>();
            playerMovement.SlowDown();
            Destroy(gameObject);
        }
    }
}
