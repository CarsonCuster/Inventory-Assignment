using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// this script handles the base item behaviours
public class Items : MonoBehaviour
{
//This function will disable the game object (this script is attached to) when it collides with the player
     
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
          Debug.Log("you picked me up");
          gameObject.SetActive(false);
        }
    }
}