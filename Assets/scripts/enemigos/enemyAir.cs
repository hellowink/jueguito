using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAir : MonoBehaviour
{
    public float life = 1f;

    public float speed = 5f;
    public float rangeOfVision = 10f;
    private Transform _player;
    private bool _playerOnRange = false;
    private changeBall _changeBall;


    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _changeBall = _player.GetComponent<changeBall>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, _player.position);
        _playerOnRange = distance <= rangeOfVision;

        if (_playerOnRange)
        {
            ChasePlayer();
        }
    }

    void ChasePlayer()
    {
        Vector3 direction = (_player.position - transform.position).normalized;

        transform.position += direction * speed * Time.deltaTime;

        transform.LookAt(_player);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && _changeBall.normalForm)
        {

        }
    }
}
