
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    //This function runs when we hit another object.
    //We get information about the collision and call it "collisionInfo".
    public PlayerMovement movement;


    void OnCollisionEnter (Collision collisionInfo)
    {
        //We check if the object we collided with, has a tag called "Obstacle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // Disables players movement.  
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
 