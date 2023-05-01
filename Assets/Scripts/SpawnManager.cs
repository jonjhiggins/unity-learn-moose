using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10.0f;
    private float spawnRangeZ = 10.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2;
    private float spawnTime = 1.5f;
    void SpawnNewAmimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int sideIndex = Random.Range(0, 3);
        Vector3 spawnPosTop = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPosLeft = new Vector3(-spawnRangeX, 0, Random.Range(0, spawnRangeZ));
        Vector3 spawnPosRight = new Vector3(spawnRangeX, 0, Random.Range(0, spawnRangeZ));
        Quaternion topRotation = Quaternion.Euler(0.0f, 0, 0.0f);
        Quaternion leftRotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
        Quaternion rightRotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        Vector3[] spawnPositions = { spawnPosTop, spawnPosLeft, spawnPosRight };
        Quaternion[] spawnRotations = { topRotation, leftRotation, rightRotation };
        GameObject prefab = animalPrefabs[animalIndex];
        Instantiate(prefab, spawnPositions[sideIndex], prefab.transform.rotation * spawnRotations[sideIndex]);

    }

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnNewAmimal", startDelay, spawnTime);
    }
}
