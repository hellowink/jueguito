    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour

{
    public PowerUpController PowerUpController;
    public changeBall changeBall;
    public bool powerOfFire = false;
    public powerUpBar powerUpBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsEnemyNear())
        {
            if(PowerUpController.niumNium == true && changeBall.normalForm == true )
            {
                EatEnemy();
                powerOfFire = true;
                powerUpBar.powerActually = powerUpBar.powerMin;
                  
            }
            

            
        }
    }

    bool IsEnemyNear()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1f);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("Enemy"))
            {
                return true;
            }
        }
        return false;
    }

    void EatEnemy()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1f);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("Enemy"))
            {
                Destroy(hitCollider.gameObject);
                // agregar aca codigo para robar atributos del enemigo comido.
            }
        }
    }
}
