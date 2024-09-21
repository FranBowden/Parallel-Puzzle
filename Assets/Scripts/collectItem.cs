using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public DiamondCollector diamondCollector;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Diamond"))
        {
            diamondCollector.collectDiamond();
            Destroy(collision.gameObject);
           
        }
    }
}