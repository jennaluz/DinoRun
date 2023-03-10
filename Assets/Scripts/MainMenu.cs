using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        {
            // When 'PLAY' button is clicked it will load the game
            // can also be done with 'SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);'
            SceneManager.LoadScene(1);
            Time.timeScale = 1f;
        }
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit Game");
    }
}