using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public GameManager gm;

    private void OnTriggerEnter2D(Collider2D triggerItem)
    {
       if(triggerItem.name == "Dinosaur")
       {
        Debug.Log("Coin has been collected");
        gm.dinoScore();
        Destroy(gameObject);
       } 
    }
}
