using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    void Start()
    {

    }
    void Update()
    {
        if (GamingManager.gameContinue)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
