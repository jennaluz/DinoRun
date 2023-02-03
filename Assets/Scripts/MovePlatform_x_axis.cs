using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform_x_axis : MonoBehaviour
{
    public float leftBoundary = 0;
    public float rightBoundary = 0;
    public float platformSpeed = 1;

    public bool startMovingRight = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frames
    void Update()
    {
        //var platformVelocity = platform.velocity;
        var platformPosition = transform.localPosition;
        /*if(platformPosition.x <= leftBoundary){
            platformPosition.x = platformSpeed * Time.deltaTime;
        } else if(platformPosition.x >= rightBoundary){
            platformPosition.x = -platformSpeed * Time.deltaTime;
        }*/
        if(platformPosition.x >= rightBoundary){
            startMovingRight = false;                        
        }else if(platformPosition.x <= leftBoundary){
            startMovingRight = true;
        }
        if(startMovingRight){
            platformPosition.x += platformSpeed * Time.deltaTime;
        }else{
            platformPosition.x += -1 * platformSpeed * Time.deltaTime; //If the platform is moving left, then the movement needs to be negative
        }

        transform.localPosition = platformPosition;
        ///Debug.Log(transform.localPosition);
    }
}
