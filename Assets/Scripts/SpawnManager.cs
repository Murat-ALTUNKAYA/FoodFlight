using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 15f;
    private float spawnPosZ = 22f;
    private float standartDelay = 2;
    private float spawnInterval = 1.5f;
    public GameObject[] animalPrefabs;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",standartDelay,spawnInterval);
    }
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        if (GamingManager.gameContinue)
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }        
    }
}
