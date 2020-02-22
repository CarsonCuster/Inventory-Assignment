using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carson;
public class Item : MonoBehaviour
{
    public GameObject item;
  virtual public void HitPlayer(PlayerController pc)
  {
      Debug.Log("bye");
      Destroy(gameObject);
  }
}
