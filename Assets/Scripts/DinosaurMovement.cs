using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurMovement : MonoBehaviour
{
    public SpriteRenderer dinoSprite;
    public Animator dinoAnimate;
    public float dinoHorizontalSpeed;
    public float dinoVerticalSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            if (dinoSprite.flipX) {
                dinoSprite.flipX = false;
            }

            dinoAnimate.SetBool("isRunning", true);
            transform.position = transform.position + (Vector3.right * dinoHorizontalSpeed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            if (!dinoSprite.flipX) {
                dinoSprite.flipX = true;
            }

            dinoAnimate.SetBool("isRunning", true);
            transform.position = transform.position + (Vector3.left * dinoHorizontalSpeed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            dinoAnimate.SetBool("isJumping", true);
            transform.position = transform.position + (Vector3.up * dinoVerticalSpeed) * Time.deltaTime;
        }
        
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) {
            dinoAnimate.SetBool("isRunning", false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        dinoAnimate.SetBool("isJumping", false);

        if (collision.collider.tag == "Gameover") {
           dinoAnimate.SetBool("isDying", true); 
           Debug.Log("fell");
        }
    }
}