using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGripper : MonoBehaviour
{
    public GameObject ledge;
    public GameObject Player;

    void OnTriggerEnter()
    {
        //the parent of the Player = gripper
        Player.transform.parent = ledge.transform;
    }

    void OnTriggerExit()
    {
        Player.transform.parent = null;
    }
}
