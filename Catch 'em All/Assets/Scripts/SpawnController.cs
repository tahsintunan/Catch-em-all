using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject obstacle;

    private float curTimeBetweenSpawn;
    public float timeBetweenSpawn;
    public float timeDecrement;
    public float minTime;

    private void update()
    {
        if (curTimeBetweenSpawn > 0)
        {
            curTimeBetweenSpawn -= Time.deltaTime;
            continue;
        }
        Instantiate(obstacle);
        curTimeBetweenSpawn = timeBetweenSpawn;
        if (timeBetweenSpawn > minTime)
            timeBetweenSpawn -= timeDecrement;
    }
}
