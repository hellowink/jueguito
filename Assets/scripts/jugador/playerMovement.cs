using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float drag = 5.0f; // Freno
    public float jumpForce = 5f; // Fuerza del salto
    private Vector3 movementDirection;
    private Rigidbody rb;
    public float speedOriginal = 10f;
    public float speedSlowed = 5f;
    public bool isGrounded = false;

    public void SlowDown()
    {
        speed = speedSlowed;
        StartCoroutine(RestoreSpeed());
    }

    private IEnumerator RestoreSpeed()
    {
        yield return new WaitForSeconds(3f);
        speed = speedOriginal;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Obtén la dirección de la cámara
        Vector3 cameraDirection = Camera.main.transform.forward;
        cameraDirection.y = 0;
        cameraDirection.Normalize();
        // Variables para almacenar el movimiento horizontal y vertical
        float horizontal = -Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        // Calcula la dirección del movimiento
        movementDirection = horizontal * Vector3.Cross(cameraDirection, Vector3.up) + vertical * cameraDirection;
        movementDirection.Normalize();
        // Mueve el personaje
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            rb.velocity = new Vector3(movementDirection.x * speed, rb.velocity.y, movementDirection.z * speed);
        }
        else
        {
            // Frena el personaje
            rb.velocity = new Vector3(Mathf.Lerp(rb.velocity.x, 0, drag * Time.deltaTime), rb.velocity.y, Mathf.Lerp(rb.velocity.z, 0, drag * Time.deltaTime));
        }
        // Salta
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded== true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si la colisión es con el suelo
        if (collision.gameObject.CompareTag("floor"))
        {
            isGrounded = true; // Indica que el jugador está en el suelo
        }



    }
}





