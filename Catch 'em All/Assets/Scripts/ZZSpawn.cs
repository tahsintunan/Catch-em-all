using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZZSpawn : MonoBehaviour
{
    public GameObject obstacle;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime;

    private void update()
    {
        if (timeBtwSpawn <= 0)
        {
            Instantiate(obstacle);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= minTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
