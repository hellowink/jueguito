using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{
    public Transform player; 
    public float distance = 5f; 
    public float height = 2f; 
    public float sensitivity = 5f; 
    public float playerRotationSpeed = 5f;

    private float _mouseX = 0f;
    private float _mouseY = 0f;

    void LateUpdate()
    {
        transform.position = player.position - transform.forward * distance + new Vector3(0, height, 0);

        _mouseX += Input.GetAxis("Mouse X") * sensitivity;
        _mouseY += Input.GetAxis("Mouse Y") * sensitivity;
        _mouseY = Mathf.Clamp(_mouseY, -90f, 90f);
        transform.rotation = Quaternion.Euler(-_mouseY, _mouseX, 0);

        player.rotation = Quaternion.Euler(0, _mouseX, 0);
    }
}
