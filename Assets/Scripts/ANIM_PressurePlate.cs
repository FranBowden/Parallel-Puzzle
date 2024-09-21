using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANIM_PressurePlate : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Block"))
        {
            GetComponent<Animator>().SetTrigger("CollisionTrigger");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Block"))
        {
            GetComponent<Animator>().ResetTrigger("CollisionTrigger");
        }
    }
} 
