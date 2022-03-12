using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float Speed = 5.0f;

    void Update()
    {
        if (GamingManager.GameContinue)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        }
    }
}
