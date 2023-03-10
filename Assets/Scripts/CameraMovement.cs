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

        //Next function is so that the camera waits for a bit before moving
        StartCoroutine(DelayCameraMovement());   
    }

    public IEnumerator DelayCameraMovement()
    {
        float originalCameraSpeed = cameraSpeed;
        cameraSpeed = 0;
        yield return new WaitForSecondsRealtime(1);
        cameraSpeed = originalCameraSpeed;
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
        if(cameraPosition.x >= 210){
            cameraSpeed = 0;
        }
        if(cameraPosition.x <= 95){
            cameraPosition.x += cameraSpeed * Time.deltaTime;
        }
        if(cameraPosition.x >= 95 && cameraPosition.y >= -34){
            cameraPosition.y += -cameraSpeed * Time.deltaTime;
        }else{
            cameraPosition.x += cameraSpeed * Time.deltaTime;
        }
        mainCamera.gameObject.transform.position = cameraPosition;
    }
}
