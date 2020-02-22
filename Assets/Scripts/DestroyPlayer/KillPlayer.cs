using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carson;
public class KillPlayer : Item
{
    override public void HitPlayer(PlayerController pc) 
    {
        pc.gameObject.SetActive(false);
    }
}
