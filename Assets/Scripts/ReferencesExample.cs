using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferencesExample : MonoBehaviour
{
    

    // External references (Set in inspector)
    public GameObject sphere;
    public GameObject capsule;

    // External reference (set via tag - see start method below)
    public Camera mainCamera; 


    // References for components on this gameobject. 
    public Collider collider; // set via inspector
    private Rigidbody rigidbody; // set via code (see below)


    void Start()
    {
        Debug.Log("Look at my code - double click this message!");

        mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        rigidbody = GetComponent<Rigidbody>();
    }

}
