using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{
    public float jumpForce = 10f;

  

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Block") || collision.CompareTag("Player")) 
        {

            print("Collision");
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    
    }
}
