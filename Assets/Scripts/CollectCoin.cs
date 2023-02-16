using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioController audioController;
    public GameManager gm;

    void Start()
    {
        audioController = GameObject.FindGameObjectWithTag("Manager").GetComponent<AudioController>();
    }

    private void OnTriggerEnter2D(Collider2D triggerItem)
    {
       if(triggerItem.name == "Dinosaur")
       {
        Debug.Log("Coin has been collected");
        audioController.Play("CollectCoin");
        gm.dinoScore();
        Destroy(gameObject);
       } 
    }
}
