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
    private bool esFurby = true; //estado base
    private float tiempoCambiarMaterial = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Cuando se presiona la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space) && powerUpBar.powerActually == powerUpBar.powerMax)
        {
            // Inicia el coroutine para cambiar el material
            
            EatEnemy();
            
            powerUpBar.powerActually = powerUpBar.powerMin;
        }
    }

    IEnumerator CambiarMaterialTemporal()
    {
        // Guarda el material actual
        Material materialActual = rendererPlayer.material;

        // Cambia el material
        rendererPlayer.material = esFurby ? materialFireMonster : materialFurby;
        esFurby = !esFurby;

        // Espera 4 segundos
        yield return new WaitForSeconds(tiempoCambiarMaterial);
        powerOfFire = false;

        // Vuelve al material anterior
        rendererPlayer.material = materialActual;


    }

    IEnumerator CambiarMaterialTemporalIce()
    {
        // Guarda el material actual
        Material materialActual = rendererPlayer.material;

        // Cambia el material
        rendererPlayer.material = esFurby ? materialIceWall : materialFurby;
        esFurby = !esFurby;

        // Espera 4 segundos
        yield return new WaitForSeconds(tiempoCambiarMaterial);
        powerOfFire = false;

        // Vuelve al material anterior
        rendererPlayer.material = materialActual;


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
                powerOfFire = true;
                // agregar aca codigo para robar atributos del enemigo comido.
                StartCoroutine(CambiarMaterialTemporal());
            }

            if (hitCollider.CompareTag("EnemyIce"))
            {
                Destroy(hitCollider.gameObject);
                powerOfFire = true;
                // agregar aca codigo para robar atributos del enemigo comido.
                StartCoroutine(CambiarMaterialTemporalIce());
            }
        }
    }
}
