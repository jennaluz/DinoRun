using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //public KeyCode moveRight = KeyCode.RightArrow;
    //public KeyCode moveLeft = KeyCode.LeftArrow;
    public float cameraSpeed = 5.0f;
    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var cameraPosition = mainCamera.gameObject.transform.position;       
        /*if(Input.GetKey(moveRight)){
            cameraPosition.x += cameraSpeed;
        }
        else if(Input.GetKey(moveLeft)){
            cameraPosition.x += -cameraSpeed;
        }*/
        if(cameraPosition.x >= 95){
            cameraPosition.y += -cameraSpeed * Time.deltaTime;
        }else{
            cameraPosition.x += cameraSpeed * Time.deltaTime;
        }
        mainCamera.gameObject.transform.position = cameraPosition;
    }
}
