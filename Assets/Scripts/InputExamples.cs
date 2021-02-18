using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputExamples : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A is pressed");
        }        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space button is pressed");
        }        

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse button 0 pressed");
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse button 1 pressed");
        }
    }
}
