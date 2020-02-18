using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPooler : MonoBehaviour
{
    public static ItemPooler instance;
    public List<GameObject> pool;
    public GameObject fallingItem;
    public int itemCount;
    // Start is called before the first frame update
    void Start()
    {
      pool = new List<GameObject>();
        for (int i = 0; i < itemCount; i++)
        {
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
