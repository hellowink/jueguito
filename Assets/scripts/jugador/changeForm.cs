using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeForm : MonoBehaviour
{
    public Mesh meshCapsule; 
    public Mesh meshSphere; 
    private MeshFilter meshFilter; 
    public bool normalForm = true; 
    public playerMovement playerMovement; 
    public pastilla pastilla; 
    public GameObject player;
    public GameObject esfera;


    void Start()
    {    
        meshFilter = GetComponent<MeshFilter>(); 
        playerMovement = GetComponent<playerMovement>(); 
        pastilla = GetComponent<pastilla>();
    }

    void Update()
    {
        if (pastilla.grajea)
        {
            if (Input.GetKeyDown(KeyCode.Q)) { }
        }

    }
}
