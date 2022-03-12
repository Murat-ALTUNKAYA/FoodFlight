using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamingManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;
    public Text scoreText, livesText;
    public static bool gameContinue = true;
    void Start()
    {

    }
    void Update()
    {

    }
    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            gameContinue = false;
            lives = 0;
        }
        livesText.text = lives + "";
    }
    public void AddScore(int value)
    {
        if (gameContinue)
        {
            score += value;
            scoreText.text = score + "";
        }        
    }

}
