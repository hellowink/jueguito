using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{

    public lifeBarController lifeBarController;

    public float life = 1f;

    public float speed = 5f; 
    public float rangeOfVision = 10f; 
    private Transform _player;
    private bool _playerOnRange = false; 

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float distancia = Vector3.Distance(transform.position, _player.position);
        _playerOnRange = distancia <= rangeOfVision;

        if (_playerOnRange)
        {
            ChasePlayer();
        }
    }

    void ChasePlayer()
    {
        Vector3 direccion = (_player.position - transform.position).normalized;

        direccion.y = 0;

        transform.position += direccion * speed * Time.deltaTime;

        transform.LookAt(new Vector3 (_player.position.x, transform.position.y, _player.position.z));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"){}
    }

    
}
