using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
     public float speed = 5.0f;
    void Update()
    {
        Vector3 cameraDirection = Camera.main.transform.forward;

        cameraDirection.y = 0;

        cameraDirection.Normalize();

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += cameraDirection * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= cameraDirection * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.Cross(cameraDirection, Vector3.up).normalized * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= Vector3.Cross(cameraDirection, Vector3.up).normalized * speed * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            transform.position -= (cameraDirection - Vector3.Cross(cameraDirection, Vector3.up).normalized) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            transform.position -= (cameraDirection + Vector3.Cross(cameraDirection, Vector3.up).normalized) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            transform.position += (cameraDirection - Vector3.Cross(cameraDirection, Vector3.up).normalized) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            transform.position += (cameraDirection + Vector3.Cross(cameraDirection, Vector3.up).normalized) * speed * Time.deltaTime;
        }
    }
}

