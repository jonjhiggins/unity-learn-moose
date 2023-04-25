using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2;
    private float spawnTime = 1.5f;
    void SpawnNewAmimal()
    {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            GameObject prefab = animalPrefabs[animalIndex];
            Instantiate(prefab, spawnPos, prefab.transform.rotation);

    }

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnNewAmimal", startDelay,spawnTime);
    }
}
