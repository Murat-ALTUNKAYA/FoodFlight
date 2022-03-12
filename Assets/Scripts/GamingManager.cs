using UnityEngine;
using UnityEngine.UI;

public class GamingManager : MonoBehaviour
{
    public static int score = 0, lives = 3;
    public Text ScoreText, LivesText;
    public static bool GameContinue = true;

    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            GameContinue = false;
            lives = 0;
        }
        LivesText.text = "Vitality : " + lives + "";
    }
    public void AddScore(int value)
    {
        if (GameContinue)
        {
            score += value;
            ScoreText.text = "Score : " + score + "";
        }
    }

}
