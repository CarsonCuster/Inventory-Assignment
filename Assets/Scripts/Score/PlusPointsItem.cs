using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carson;
public class PlusPointsItem: Item
{
    //If the player collides with this item add points to the score  
    override public void HitPlayer(PlayerController pc)
   {
        pc.score++;
    }
}
