using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject item;
  void OnCollisionEnter2D(Collision2D col)
  {
      Debug.Log("bye");
      Destroy(gameObject);
  }
}
