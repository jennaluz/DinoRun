using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TestPlayerMovement dino;

    private int _dinoScore;
    public Text dinoScoreText;

    public void dinoScore(){
        _dinoScore++;
        Debug.Log(_dinoScore);
        this.dinoScoreText.text = _dinoScore.ToString();
    }
}
