using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D p1rb;
    public Rigidbody2D p2rb;

    //check gro9und
    public Transform groundCheck;
    public LayerMask groundLayer;
    public bool isGrounded;
   // AudioSource jumpSound;
    public float xPosSpeed = 5f;
    public float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        p1rb = GetComponent<Rigidbody2D>();
       // jumpSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // allows the player to move left and right
        float xPos = Input.GetAxis("Horizontal");

        // X-Axis movement for player 1
        p1rb.velocity = new Vector2(xPos * xPosSpeed, p1rb.velocity.y);

        // X-Axis movement for player 2   
        p2rb.velocity = new Vector2(xPos * xPosSpeed, p2rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())  // Only jump if grounded
        {
            p1rb.velocity = new Vector2(p1rb.velocity.x, jumpForce);
            p2rb.velocity = new Vector2(p2rb.velocity.x, -jumpForce);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.5f, groundLayer);
    }
}
