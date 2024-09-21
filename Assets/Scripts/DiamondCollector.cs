using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiamondCollector : MonoBehaviour
{
    public float diamondsCollected = 3;
    public TMP_Text diamondsText;

    public void collectDiamond()
    {
        if(diamondsCollected > 0)
        {
            diamondsCollected--;
        }
       
        diamondsText.text = "Diamonds needed: " + diamondsCollected;
    }
}