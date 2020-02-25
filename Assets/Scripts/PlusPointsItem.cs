using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carson;
public class PlusPointsItem: Item
{
    //Description: If the player collides with this item add points to the score  
    override public void HitPlayer(PlayerController pc)
   {
        pc.score++;//adds a point to the score when the player collideds with this item.
        //Destroy(gameObject);// destroys the attached game object.
    }
}
