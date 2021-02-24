using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float upSpeed = 0.5f;
    Rigidbody rb;

    public float Speed { get => speed; set => speed = value; }
    public float UpSpeed { get => upSpeed; set => upSpeed = value; }
    public Rigidbody Rb { get => rb; set => rb = value; }



    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //Moving forward
        if (Input.GetKey(KeyCode.W))
        {
            Rb.AddForce(Vector3.forward * Speed, ForceMode.Impulse);
            Rb.AddForce(Vector3.up * UpSpeed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Rb.AddForce(Vector3.back * Speed, ForceMode.Impulse);
            Rb.AddForce(Vector3.up * UpSpeed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Rb.AddForce(Vector3.right * Speed, ForceMode.Impulse);
            Rb.AddForce(Vector3.up * UpSpeed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Rb.AddForce(Vector3.left * Speed, ForceMode.Impulse);
            Rb.AddForce(Vector3.up * UpSpeed, ForceMode.Impulse);
        }


    }
}
