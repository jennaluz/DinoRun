using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool isOver = false;
    public GameObject GameOverCanvas;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Gameover") {
           Debug.Log("Game Over");

            GameOverCanvas.SetActive(true);
            Time.timeScale = 0f;

            isOver = true;
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
