using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private GamingManager gamingManager;
    void Start()
    {
        gamingManager = GameObject.Find("GamingManager").GetComponent<GamingManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GamingManager.GameContinue)
        {
            if (other.CompareTag("Player"))
            {
                gamingManager.AddLives(-1);
                Destroy(gameObject);
            }
            else if (other.CompareTag("Animal"))
            {
                gamingManager.AddScore(5);
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}
