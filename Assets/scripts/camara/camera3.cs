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
        _offset = transform.position - _target.position; // POSICI�N ENTRE LA C�MARA Y EL OBJETO QUE QUEREMOS SEGUIR
    }

    private void LateUpdate()
    {
        transform.position = _target.position + _offset;
    }
}
