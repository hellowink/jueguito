using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float drag = 5.0f; 
    public float jumpForce = 40f; 
    private Vector3 _movementDirection;
    private Rigidbody _rb;
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
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        Vector3 cameraDirection = Camera.main.transform.forward;
        cameraDirection.y = 0;
        cameraDirection.Normalize();

        float horizontal = -Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        _movementDirection = horizontal * Vector3.Cross(cameraDirection, Vector3.up) + vertical * cameraDirection;
        _movementDirection.Normalize();

        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            _rb.velocity = new Vector3(_movementDirection.x * speed, _rb.velocity.y, _movementDirection.z * speed);
        }
        else
        {

            _rb.velocity = new Vector3(Mathf.Lerp(_rb.velocity.x, 0, drag * Time.deltaTime), _rb.velocity.y, Mathf.Lerp(_rb.velocity.z, 0, drag * Time.deltaTime));
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded== true)
        {
            _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("floor"))
        {
            isGrounded = true; 
        }
    }

    void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.CompareTag("floor"))
        {
            isGrounded = false;
        }
    }
}





