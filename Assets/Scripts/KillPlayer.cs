using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carson;
public class KillPlayer : Item
{
    override public void HitPlayer(PlayerController pc) // Pc = PlayerController. 
    {
        pc.gameObject.SetActive(false); //When this item collides with the player, the player is set to false
        base.HitPlayer(pc);
                //GetComponent<SpriteRenderer>().color = Color.red;
    }
}
