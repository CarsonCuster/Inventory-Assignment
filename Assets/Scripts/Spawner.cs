using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject item;

    public float timeBtwSpawn;
    public float startTimeBtwSpawn;

    public void Update()
    {
        if(timeBtwSpawn <= 0) //When our timer hits 0 or is less than zero, we will instantiate the item to the position of the spawner.
        {
            Instantiate(item, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn; //Then we reset the timer

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime; //We are counting down from the float variable that we can change in the inspector
        }
    }

}
