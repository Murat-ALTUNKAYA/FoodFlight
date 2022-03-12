using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 15f, spawnPosZ = 22f, standartDelay = 2,spawnInterval = 1.5f;
    public GameObject[] animalPrefabs;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",standartDelay,spawnInterval);
    }
    void SpawnRandomAnimal()
    {
        if (GamingManager.GameContinue)
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }        
    }
}
