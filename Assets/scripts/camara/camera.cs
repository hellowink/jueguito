using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform player; //referencia al player

    public float smoothSpeed = 0.125f ; // velocidad de suavizado

    public Vector3 offset; // distancia entre la camara y el jugador


   
    public void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        transform.LookAt(player);

        transform.rotation = Quaternion.Euler(45, transform.rotation.eulerAngles.y , 0);
    }
}
