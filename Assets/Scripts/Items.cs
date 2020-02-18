using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// this script handles the base item behaviour
public class Items : MonoBehaviour
{
    public int powerup;
//will disable itself when it collides with the player
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
          Debug.Log("you picked me up");
          //Destroy(gameObject); 
          gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
}