using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    public GameObject item;
    // Start is called before the first frame update
     void Start()
    {
        Instantiate(item, transform.position, Quaternion.identity);
    }
}