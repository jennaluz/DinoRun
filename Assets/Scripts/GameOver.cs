using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool isOver = false;
    public GameObject GameOverCanvas;
    public Image healthBar;
    public float healthAmt = 100f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Gameover")
        {
            if (collision.collider.name.Contains("Boundary")) {
                healthAmt = 0;
                healthBar.fillAmount = healthAmt / 100f;
            } else {
                healthAmt -= 33.5f;
                healthBar.fillAmount = healthAmt / 100f;
                this.gameObject.GetComponent<DinosaurMovement>().DinoDamage();
            }

            if (healthAmt <= 0)
            {
                this.gameObject.GetComponent<DinosaurMovement>().DinoDead();
                healthAmt = 0;

                Debug.Log("YOU'RE DEAD!");
                Debug.Log("Game Over");

                GameOverCanvas.SetActive(true);
                Time.timeScale = 0f;

                isOver = true;
            }
        }
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        {
            // When 'PLAY' button is clicked it will load the game
            //can be done with SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            SceneManager.LoadScene(1);
            if(isOver == true)
            {
                GameOverCanvas.SetActive(false);
                isOver = false;
            }
            Time.timeScale = 1f;
        }
    }
}
