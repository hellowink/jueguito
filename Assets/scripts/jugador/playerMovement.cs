using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    
       

    void Update()
    {
        // Obtén la dirección de la cámara
        Vector3 cameraDirection = Camera.main.transform.forward;

        // Elimina el componente Y de la dirección para que el personaje se mueva en el plano horizontal
        cameraDirection.y = 0;

        // Normaliza la dirección para que tenga longitud 1
        cameraDirection.Normalize();

        // Mueve el personaje según las teclas WASD
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += cameraDirection * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position -= cameraDirection.normalized * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= cameraDirection * speed * Time.deltaTime;
        }
        
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= cameraDirection.normalized * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.Cross(cameraDirection, Vector3.up).normalized * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position -= Vector3.Cross(cameraDirection, Vector3.up).normalized * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= Vector3.Cross(cameraDirection, Vector3.up).normalized * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= cameraDirection.normalized * speed * Time.deltaTime;
        }

        // Mueve el personaje en las diagonales
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            Vector3 diagonalDirection = Vector3.Cross(cameraDirection, Vector3.up) - cameraDirection;
            diagonalDirection.Normalize();
            transform.position += diagonalDirection * speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            Vector3 diagonalDirection = Vector3.Cross(cameraDirection, Vector3.up) - cameraDirection;
            diagonalDirection.Normalize();
            transform.position += diagonalDirection * speed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            Vector3 diagonalDirection = Vector3.Cross(cameraDirection, Vector3.up) - cameraDirection;
            diagonalDirection.Normalize();
            transform.position -= diagonalDirection * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            Vector3 diagonalDirection = Vector3.Cross(cameraDirection, Vector3.up) - cameraDirection;
            diagonalDirection.Normalize();
            transform.position -= diagonalDirection * speed * Time.deltaTime;
        }
    }




}
