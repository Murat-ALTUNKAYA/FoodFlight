using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 40.0f;
    public float loverBound = -10.0f;
    void Start()
    {

    }

    void Update()
    {
        Destroied();
    }
    public void Destroied()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < loverBound)
        {
            Destroy(gameObject);
        }
    }
}
