using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public DinosaurMovement dino;

    private int _dinoScore;
    public Text dinoScoreText;

    public void dinoScore(){
        _dinoScore++;
        Debug.Log(_dinoScore.ToString());
        this.dinoScoreText.text = _dinoScore.ToString();
    }
}
