using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerMovement : MonoBehaviour
{
    public KeyCode jump = KeyCode.Space;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode moveLeft = KeyCode.A;

    public float speed = 10.0f;
    protected Rigidbody2D testPlayer;

    // Start is called before the first frame update
    void Start()
    {
        testPlayer = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        var playerVelocity = testPlayer.velocity;
        if(Input.GetKeyDown(jump)){
            playerVelocity.y = speed;
        }
        else if(Input.GetKey(moveRight)){
            playerVelocity.x = speed;
        }
        else if(Input.GetKey(moveLeft)){
            playerVelocity.x = -speed;
        }
        else{
            playerVelocity.x = 0;
            //playerVelocity.y = 0;
        }
        testPlayer.velocity = playerVelocity;
    }
}
