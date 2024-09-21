using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleSwap : MonoBehaviour
{
    public bool PlayerTrigger = false;
    private GameObject block;


    private void Start()
    {
        block = GetComponent<GameObject>();
    }
    private void Update()
    {
       block = GameObject.FindWithTag("Block");
 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
     
        if (collision.CompareTag("Block"))
        {
            flipBlock(collision.transform.position.y > 1);
        }
        else if (PlayerTrigger && collision.CompareTag("Player"))
        {
            flipBlock(block.transform.position.y > 1);
        }

        else
        {
            return;
        }
    }


    private void flipBlock(bool isAbove)
    {
        float newYPosition = isAbove ? -0.4f : 1.5f;
        block.transform.position = new Vector2(block.transform.position.x, newYPosition);
        block.GetComponent<Rigidbody2D>().gravityScale = isAbove ? -1 : 1;
    }
}
