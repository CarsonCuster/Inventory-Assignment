using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePattern;

    public float timeBtwSpawn;
    public float startTimeBtwSpawn;

    public void Update()
    {
        if(timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePattern.Length);
            Instantiate(obstaclePattern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
        
        
    }

}
