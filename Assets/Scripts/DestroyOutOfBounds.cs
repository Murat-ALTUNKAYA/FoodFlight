using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 40.0f;
    public float loverBound = -2.0f;
    private GamingManager gamingManager;
    void Start()
    {
        gamingManager = GameObject.Find("GamingManager").GetComponent<GamingManager>();
    }

    void Update()
    {
        if (GamingManager.gameContinue)
        {
            Destroied();
        }
    }
    public void Destroied()
    {
        if (transform.position.z > topBound)
        {
            //gamingManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.z < loverBound)
        {
            gamingManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
