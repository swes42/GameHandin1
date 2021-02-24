using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public Rigidbody rigidbody;

    void Start()
    {
               rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("H key was pressed");

        }
    }

    void OnCollisionEnter(Collision collider)
    {
        Debug.Log(collider.gameObject.name);
        rigidbody.AddForce(Vector3.up * 100);

    }

}
