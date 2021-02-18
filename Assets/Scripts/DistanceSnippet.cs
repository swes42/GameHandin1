using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceSnippet : MonoBehaviour
{

    public GameObject cube1;
    public GameObject cube2;

    void Update()
    {
        float distance = Vector3.Distance(cube1.transform.position, cube2.transform.position);

        Debug.Log(distance);
    }
}