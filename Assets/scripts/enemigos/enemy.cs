using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class enemy : MonoBehaviour
{
    [SerializeField] private float _chaseDist = 6.0f;
    [SerializeField] private float _atkDist = 2.0f;
    [SerializeField] private float _changeNodeDist = 0.5f;

    private Transform _target, _actualNode;
    private List<Transform> _navMeshNodes = new();
    public List<Transform> NavMeshNodes
    { 
        get { return _navMeshNodes; } 
        set { _navMeshNodes = value; } 
    }

    private NavMeshAgent _agent;

    public float life = 1f;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        GameManager.Instance.enemies.Add(this);
    }

    public void Initialize()
    {
        _target = GameManager.Instance.playerMovement.transform;

        _actualNode = GetNewNode();

        _agent.SetDestination(_actualNode.position);
    }

    private void Update()
    {
        if(Vector3.SqrMagnitude(transform.position - _target.position) <= (_chaseDist * _chaseDist))
        {
            if(Vector3.SqrMagnitude(transform.position - _target.position) <= (_atkDist * _atkDist))
            {
                if(_agent.isStopped) _agent.isStopped = true;

                Debug.Log("golpecito");
            }
            else
            {
                if (_agent.isStopped) _agent.isStopped = false;
                _agent.SetDestination(_target.position);
            }
        }
        else
        {
            if (_agent.destination != _actualNode.position) _agent.SetDestination(_actualNode.position);

            if(Vector3.SqrMagnitude(transform.position - _target.position) <= (_changeNodeDist * _changeNodeDist))
            {
                _actualNode = GetNewNode(_actualNode);

                _agent.SetDestination(_actualNode.position);
            }
        }
    }

    private Transform GetNewNode(Transform lastNode = null)
    {
        Transform newNode = _navMeshNodes[UnityEngine.Random.Range(0, _navMeshNodes.Count)];

        while(lastNode == newNode)
        {
            newNode = _navMeshNodes[UnityEngine.Random.Range(0, _navMeshNodes.Count)] ;
        }

        return newNode;
    }
}
