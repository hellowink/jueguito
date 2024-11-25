using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour

{
    public PowerUpController PowerUpController;
    public changeBall changeBall;
    public bool powerOfFire = false;
    public powerUpBar powerUpBar;
    public Renderer rendererPlayer;
    public Material materialFurby;
    public Material materialFireMonster;
    public Material materialIceWall;
    private bool _isFurby = true; 
    private float _timeChangeMaterial = 4f;
    public LayerMask layer;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && powerUpBar.powerActually == powerUpBar.powerMax)
        {
            EatEnemy(); 
        }
    }

    IEnumerator ChangeMaterialFire()
    {
        Material actualMaterial_Fire = rendererPlayer.material;

        rendererPlayer.material = _isFurby ? materialFireMonster : materialFurby;
        _isFurby = !_isFurby;

        yield return new WaitForSeconds(_timeChangeMaterial);
        powerOfFire = false;

        rendererPlayer.material = actualMaterial_Fire;


    }

    IEnumerator ChangeMaterialIce()
    {
        Material actualMaterial_Ice = rendererPlayer.material;

        rendererPlayer.material = _isFurby ? materialIceWall : materialFurby;
        _isFurby = !_isFurby;

        yield return new WaitForSeconds(_timeChangeMaterial);
        powerOfFire = false;

        rendererPlayer.material = actualMaterial_Ice;

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
        int index = 0;
        float distance = Mathf.Infinity;


        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1f, layer);

        if (hitColliders.Length == 0)   
            return;

        powerUpBar.powerActually = powerUpBar.powerMin;

        for (int i = 0; i < hitColliders.Length; i++)
        {
            var x = Vector3.Distance(hitColliders[i].transform.position, transform.position);

            if (x < distance)
            {
                index = i; 
            }
        }
  
        if (hitColliders[index].gameObject.CompareTag("Enemy"))
        {            
            Destroy(hitColliders[index].gameObject);
            powerOfFire = true;

            StartCoroutine(ChangeMaterialFire());       
        }

        if (hitColliders[index].CompareTag("EnemyIce"))
        {
            Destroy(hitColliders[index].gameObject);
            powerOfFire = true;

            StartCoroutine(ChangeMaterialIce());
        }
        
    }


}
