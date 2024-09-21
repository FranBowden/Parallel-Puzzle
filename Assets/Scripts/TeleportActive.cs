using UnityEngine;

public class TeleportActive : MonoBehaviour
{
    public SpriteRenderer light1, light2;
    public bool isActive = false;


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.CompareTag("Block") || collision.CompareTag("Player")) {
            
            light1.color = new Color(0, 255, 255);
            light2.color = new Color(0, 255, 255);
            isActive = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
       
        light1.color = new Color(0, 0, 0);
        light2.color = new Color(0, 0, 0);
        isActive = false;
    }
}
