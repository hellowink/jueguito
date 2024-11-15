using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AINodeManager : MonoBehaviour
{
    private Transform[] _nodes;

    private void Start()
    {
        _nodes = GetComponentsInChildren<Transform>();
        
        foreach(enemy enemy in GameManager.Instance.enemies)
        {
            enemy.NavMeshNodes.AddRange(_nodes);
            enemy.Initialize();
        }
    }
}
