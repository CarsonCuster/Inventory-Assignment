using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Carson Custer
//Put this script on the player in conjunction with the Player Controller script to move the player
[RequireComponent(typeof(Carson.PlayerController))]
public class PlayerControllerInput : MonoBehaviour
{
    Carson.PlayerController controller;

    void Start()
    {
        //Here we are making sure we are calling upon the PlayerController script so we can use the functions in it.
        //We are also checking to make sure it is setup along side this one so it will function properly. If not, we tell the player they need to apply it.
        controller = GetComponent<Carson.PlayerController>();
        if(controller == null)
        {
            Debug.LogError("PlayerControllerInput requires PlayerController to function");
        }
    }


    void Update()
    {
        //The below if statements check every frame if the player is pressing left or right. If the player does press left or right,
        //we then call the controller script to retreive the Move function, which applies the lerp to our gameobject.
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            controller.Move(-1);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            controller.Move(1);
        }
    }
}
 // if(left > 0)
        //     if(Input.GetKeyDown(KeyCode.LeftArrow))
        //     {
        //         transform.position = transform.position + new Vector3(-1, 0, 0);
        //         left--;
        //         right++;
        //     }
        // if(right > 0)
        //     if(Input.GetKeyDown(KeyCode.RightArrow))
        //     {
                
        //     }
