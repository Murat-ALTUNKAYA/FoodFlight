using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Text tbr, score2;
    void Start()
    {
        
    }

    void Update()
    {

    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
