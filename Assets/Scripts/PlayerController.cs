using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Carson Wells Custer
//Apply both the PlayerController script and PlayerControllerInput script to the player sprite, and put the sprite on the origin.
namespace Carson
{
public class PlayerController : MonoBehaviour
{
    public int score;
    private int move = 0;
    [Tooltip("Amount of lanes in your course")]
    public int trackWidth = 7;
    Vector3 desiredPosition;
    Vector3 a;
    float t = 1; 
    [Tooltip("How long it takes to move between lanes")]
    public float timeToMove = 1;
    
    void Start()
    {
        //We are defining the above Vector3's with our current gameobjects position
        a = transform.position;
        desiredPosition = transform.position;
    }

    void Update()
    {
        //We are creating a timer so we can tell our transform function how long we want to take to get from point a to point b
        t = t+Time.deltaTime/timeToMove;
        //This is where the movement is defined. We are saying that when our current position is moved to our desired position, to take t amount of time
        transform.position = Vector3.Lerp(a, desiredPosition,t);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.GetComponent<Item>() != null)//checks if the player has collided with an item.
        {
            col.gameObject.GetComponent<Item>().HitPlayer(this);
            // Calls on the hit player function on collision and references itself as the other game object in the collsion.  
        }
    }


    public void Move(int dir)
    {
        //This is where we define the direction our player will be moving. Whether they will be moving left (-1) or right (1).
        //We also are checking to see if the player is able to move anymore left and right with the below if statements by checking if 
        //the int is greater or less than the trackWidth integer.
        if(dir == 1 && move < trackWidth/2)
        {
            a = transform.position;
            //We are telling the computer what our desired position is by telling it we want to move to a new Vector3 in a positive direction
            desiredPosition = desiredPosition + new Vector3 (1, 0, 0);
            //Then we add one to our move integer so when we hit the limit, we can't move right anymore
            move++;
            t = 0;
            
        }
        else if(dir == -1 && move > -trackWidth/2)
        {
            a = transform.position;
            desiredPosition = desiredPosition + new Vector3 (-1, 0, 0);
            //Same instance down here, but in the opposite direction. We subtract one to our move integer so when we hit the limit, we can't move left anymore
            move--;
            t=0;
            
        }
    }
}
}
