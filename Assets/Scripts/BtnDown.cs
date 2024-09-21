using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BtnDown : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
       GetComponent<SpriteRenderer>().color = new Color(255,165,248 );
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<SpriteRenderer>().color = new Color(255, 0, 238);
    }



}
