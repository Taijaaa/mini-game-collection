using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonSpawn : MonoBehaviour
{
    public GameObject balloons;
    public float spawnDelay = 5f;
    public float spawnInterval = 4f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnDelay, spawnInterval);
    }


    void SpawnObject()
    {
        Vector2 randomSpawnPosition = new Vector2(Random.Range(-4, 2), Random.Range(-2, 4));

        GameObject spawnedObjects = Instantiate(balloons, randomSpawnPosition, Quaternion.identity);
    }
}
