using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class airEnemy : MonoBehaviour
{
    public lifeBarController lifeBarController;
    public float radioVision = 10f;
    public float speedMovement = 5f;
    public float speedShoot = 10f;
    public float shootTimer = 2f;
    public float bulletLifeTime = 2.0f;
    private Transform _player;
    public GameObject bulletAir;
    private float _timeLastShot = 0f;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float distancia = Vector3.Distance(transform.position, _player.position);
        if (distancia <= radioVision)
        {
            transform.LookAt(new Vector3(_player.position.x, transform.position.y, _player.position.z));

            transform.position += (transform.position - _player.position).normalized * speedMovement * Time.deltaTime;

            if (Time.time > _timeLastShot + shootTimer)
            {
                _timeLastShot = Time.time;
                Shoot();
            }
        }
    }

    void Shoot()
    {
        GameObject proyectil = Instantiate(bulletAir, transform.position, transform.rotation);

        proyectil.GetComponent<Rigidbody>().velocity = (_player.position - transform.position).normalized * speedShoot;

        Destroy(proyectil, bulletLifeTime);

    }

    
}
