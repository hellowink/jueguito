using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{


    public Transform player; // Referencia al jugador
    public float distance = 5f; // Distancia entre la cámara y el jugador
    public float height = 2f; // Altura de la cámara respecto al jugador
    public float sensitivity = 5f; // Sensibilidad del movimiento de la cámara
    

    private float mouseX = 0f;
    private float mouseY = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        // Actualiza la posición de la cámara
        transform.position = player.position - transform.forward * distance + new Vector3(0, height, distance);

        // Actualiza la rotación de la cámara
        mouseX += Input.GetAxis("Mouse X") * sensitivity;
        mouseY += Input.GetAxis("Mouse Y") * sensitivity;
        mouseY = Mathf.Clamp(mouseY, -90f, 90f);
        transform.rotation = Quaternion.Euler(-mouseY, mouseX, 0);
    }
}