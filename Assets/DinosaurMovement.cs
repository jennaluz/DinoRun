using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurMovement : MonoBehaviour
{
    public SpriteRenderer dinoSprite;
    public Animator dinoAnimate;
    public float dinoSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            if (dinoSprite.flipX) {
                dinoSprite.flipX = false;
            }

            dinoAnimate.SetBool("isRunning", true);
            transform.position = transform.position + (Vector3.right * dinoSpeed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A)) {
            if (!dinoSprite.flipX) {
                dinoSprite.flipX = true;
            }

            dinoAnimate.SetBool("isRunning", true);
            transform.position = transform.position + (Vector3.left * dinoSpeed) * Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.D)) {
            dinoAnimate.SetBool("isRunning", false);
        }

        if (Input.GetKeyUp(KeyCode.A)) {
            dinoAnimate.SetBool("isRunning", false);
        }
    }
}
