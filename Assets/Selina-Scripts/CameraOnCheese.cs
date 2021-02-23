
using UnityEngine;

public class CameraOnCheese : MonoBehaviour
{
    public Transform target;
    public float smooth = 0.10f;
    public Vector3 offset;

    void LateUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = target.position + offset;

    }
}
