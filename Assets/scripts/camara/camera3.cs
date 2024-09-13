using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera3 : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Transform _target;

    private Vector3 _offset = new();
    private void Start()
    {
        _offset = transform.position - _target.position; // POSICIÓN ENTRE LA CÁMARA Y EL OBJETO QUE QUEREMOS SEGUIR
    }

    private void LateUpdate()
    {
        transform.position = _target.position + _offset;
    }
}
