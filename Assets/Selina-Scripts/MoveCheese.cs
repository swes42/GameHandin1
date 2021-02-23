
using UnityEngine;

public class MoveCheese : MonoBehaviour
{
   public float speed = .1f;

    // Update is called once per frame
    void Update()
    {
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");
        
        Vector3 moveDir = new Vector3(xDir, 0.0f, zDir);
        transform.position += moveDir * speed;
    }
}
