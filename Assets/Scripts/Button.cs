using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject button;
    public Text ScoreText;

    private void Update()
    {
        if (!GamingManager.GameContinue)
        {
            button.SetActive(true);
            ScoreText.text = "Score : " + GamingManager.score + "";
        }
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        GamingManager.GameContinue = true;
        button.SetActive(false);
    }
}
