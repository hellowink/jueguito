using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : enemy
{
    public int damage = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerLife playerLife = collision.gameObject.GetComponent<playerLife>();
            if (playerLife != null)
            {
                playerLife.GetDamage(damage);
            }
        }
    }
}
