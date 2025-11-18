using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonSpawn : MonoBehaviour
{
    public GameObject balloons;
    public float spawnDelay = 3f;
    public float spawnInterval = 4f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnDelay, spawnInterval);
    }


    void SpawnObject()
    {
        Vector2 randomSpawnPosition = new Vector2(Random.Range(-5, 3.5f), Random.Range(-3.5f, 5));

        GameObject spawnedObjects = Instantiate(balloons, randomSpawnPosition, Quaternion.identity);
    }
}
