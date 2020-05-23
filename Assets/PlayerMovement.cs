using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForceZ = 2000;
    public float MovementSpeed = 500;
    bool left = false;
    bool right = false;

    void Update()
    {
        if (Input.GetKey("d"))
        {
            right = true;
        }

        if (Input.GetKey("a"))
        {
            left = true;
        }
    }

    // Update is called once per frame (use fixed update when playing around with the physics engine.)
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForceZ * Time.deltaTime);

        if (right == true)
        {
            rb.AddForce(MovementSpeed * Time.deltaTime, 0, 0);
        }

        if (left == true)
        {
            rb.AddForce(-MovementSpeed * Time.deltaTime, 0, 0);
        }

        left = false;
        right = false;
    }
}
