using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            rb.velocity = new Vector3(rb.velocity.x, 5f, rb.velocity.z);
        }

        if (Input.GetKey("up")) {
            rb.velocity = new Vector3(0, 0, 5);
        }

        if (Input.GetKey("right")) {
            rb.velocity = new Vector3(5, 0, 0);
        }

        if (Input.GetKey("down")) {
            rb.velocity = new Vector3(0, 0, -5);
        }

        if (Input.GetKey("left")) {
            rb.velocity = new Vector3(-5, 0, 0);
        }
    }
}
