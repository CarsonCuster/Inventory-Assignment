using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carson;
public class Item : MonoBehaviour
{
  // Base script for the items. Holds the universal behavior  
    public GameObject item;
  virtual public void HitPlayer(PlayerController pc)// pc = PlayerController.
  {
      Debug.Log("bye");
      Destroy(gameObject);//Destroys the Item children scripts when they collide with the player.
  }
  
}
