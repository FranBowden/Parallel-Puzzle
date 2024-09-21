using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBlocks : MonoBehaviour
{
    public SpriteRenderer itemSpriteRenderer; 
    public Color[] colors; 
    public Transform playerTransform; 
    private GameObject currentShape;
    public float gravityScale;
    private void SpawnRandomShape()
    {

        if (currentShape != null)
        {
            Destroy(currentShape); //if recreated destory shape
        }

        // Create a new GameObject instance
        currentShape = new GameObject("Generated Shape");
        currentShape.tag = "Block";
        currentShape.layer = LayerMask.NameToLayer("MoveableObject");
        //add components needed
        currentShape.AddComponent<SpriteRenderer>().sprite = itemSpriteRenderer.sprite;
        currentShape.AddComponent<PolygonCollider2D>();
        currentShape.AddComponent<Rigidbody2D>();
        

        currentShape.GetComponent<SpriteRenderer>().color = colors[Random.Range(0, colors.Length)];

        currentShape.transform.position = playerTransform.position + new Vector3(0, -5f, 0f);
        currentShape.GetComponent<Rigidbody2D>().gravityScale = gravityScale;
    }


        private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) //if player collides with pressureplate and it gets triggered
        {
            SpawnRandomShape(); //spawn shape 
        }
       
    }

}
