using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] Transform target;
    public float offsetY;
    public float offsetZ;

    void LateUpdate()
    {
        transform.position= new Vector3 (target.position.x + offsetZ, target.position.y + offsetY, transform.position.z );
    }
}
