
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to the Rigidbody component
    //called rb.
    public Rigidbody rb;

    //the f on the variables, is needed when its float.
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked this as "Fixed" update because we are 
    //using it to mess with physics.
    void FixedUpdate()
    {
        //add a forward force in z-axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if ( Input.GetKey("d"))
        {
            //Only executed if condition is met
            //x-azis
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a"))
        {
            //Only executed if condition is met
            //x-azis
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
