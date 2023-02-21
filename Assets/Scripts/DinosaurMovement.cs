using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurMovement : MonoBehaviour
{
    public SpriteRenderer dinoSprite;
    public Animator dinoAnimate;
    public float dinoHorizontalSpeed;
    public float dinoVerticalSpeed;

    public AudioController audioController;

    // Start is called before the first frame update
    void Start()
    {
        audioController = GameObject.FindGameObjectWithTag("Manager").GetComponent<AudioController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            if (dinoSprite.flipX) {
                dinoSprite.flipX = false;
            }

            dinoAnimate.SetBool("isRunning", true);
            transform.position = transform.position + (Vector3.right * dinoHorizontalSpeed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A)) {
            if (!dinoSprite.flipX) {
                dinoSprite.flipX = true;
            }

            dinoAnimate.SetBool("isRunning", true);
            transform.position = transform.position + (Vector3.left * dinoHorizontalSpeed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space)) {
            dinoAnimate.SetBool("isJumping", true);
            audioController.Play("DinoJump");
            transform.position = transform.position + (Vector3.up * dinoVerticalSpeed) * Time.deltaTime;
        }
        
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) {
            dinoAnimate.SetBool("isRunning", false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        dinoAnimate.SetBool("isJumping", false);
    }

    public void DinoDamage()
    {
       audioController.Play("DinoDie"); 
    }

    public void DinoDead()
    {
        dinoAnimate.SetBool("isJumping", false);
        audioController.Play("DinoDie");
        dinoAnimate.SetBool("isDying", true);
    }
}