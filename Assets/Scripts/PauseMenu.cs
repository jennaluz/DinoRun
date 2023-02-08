using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject PauseMenuCanvas;

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Tab)){
            if(Input.GetKey(KeyCode.Escape)){
                Application.Quit();
            } else if(isPaused){
                ResumeGame();
            } else {
                Halt();
            }
        }
        if(Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }  
    }

    public void Halt()
    {
        PauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;

        isPaused = true;
    }

    public void ResumeGame()
    {
        PauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;

        isPaused = false;
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        {
            // When 'PLAY' button is clicked it will load the game
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            SceneManager.LoadScene(0);

            //Need to figure out how to reset the camera position, and score
        }
    }
}
