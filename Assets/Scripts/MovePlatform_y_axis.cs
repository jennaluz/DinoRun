using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform_y_axis : MonoBehaviour
{
    public float topBoundary = 0;
    public float bottomBoundary = 0;
    //public float platformSpeed = 1;
    private float platformSpeed;
    public bool startMovingDown = true;
    // Start is called before the first frame update
    void Start()
    {
        platformSpeed = Random.Range(0.5f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        var platformPosition = transform.localPosition;
        if(platformPosition.y >= topBoundary){
            startMovingDown = false;                        
        }else if(platformPosition.y <= bottomBoundary){
            startMovingDown = true;
        }
        if(startMovingDown){
            platformPosition.y += platformSpeed * Time.deltaTime;
        }else{
            platformPosition.y += -1 * platformSpeed * Time.deltaTime;
        }

        transform.localPosition = platformPosition;
    }
}
