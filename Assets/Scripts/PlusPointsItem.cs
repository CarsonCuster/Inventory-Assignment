using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Carson;
public class PlusPointsItem: Item
{
    public Text scoreText;
    //Description: If the player collides with this item add points to the score  
    override public void HitPlayer(PlayerController pc)
    {
        pc.score++;//adds a point to the score when the player collides with this item.
        scoreText.text = pc.score.ToString();
        base.HitPlayer(pc);
    }
}
