using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonSpawn : MonoBehaviour
{
    //Transform ball_blue_largePrefab;
    //float spawnTimerInterval = 2f;

    //Transform objectHolder;
    //float timer = 0.0f;
    //Vector2 randomPosition;
    //float randomX = 3;
    //float randomY = 3;
    public GameObject[] balloons;
    // Start is called before the first frame update
    void Start()
    {
        //Vector2 randomPosition;
        //float randomX = 3;
        //float randomY = 3;
        //objectHolder = new GameObject("Object Holder").Transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, balloons.Length);
            Vector2 randomSpawnPosition = new Vector2(Random.Range(-10, 11), Random.Range(-10, 11));

            Instantiate(balloons[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
        //float xPosition = Random.Range(0 - randomX, 0 + randomX);
        //float yPosition = Random.Range(0 - randomY, 0 + randomY);

        //randomPosition = new Vector2(xPosition, yPosition);

        //transform.position = randomPosition;
        //if (timer > spawnTimerInterval)
        //{
        //    SpawnBalloon();
        //    timer = 0.0f;

        //    spawnTimerInterval *= 0.98f;
        //    spawnTimerInterval = Mathf.Clamp(spawnTimerInterval, 0.3f, 99f);
        //}
        //else
        //{
        //    timer += timer.deltaTime;
        //}
    }

    //void SpawnBalloon()
    //{
    //    //Vector2 spawnPos = this.transform.position;
    //    //spawnPos.x += Random.Range(-1.6f, 1.6f);
    //    //Instantiate(ball_blue_largePrefab, spawnPos, Quaternion.identity, objectHolder);
    //}
}
