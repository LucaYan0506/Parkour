using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public GameObject player;        //Public variable to store a reference to the player game object
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float left_right = 0.0f;
    private float up_down = 0.0f;

   
    private Vector3 offset;            //Private variable to store the offset distance between the player and camera
    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;

        //move angles of main camera (based on the mouse)
        left_right += speedH * Input.GetAxis("Mouse X");
        up_down += Input.GetAxis("Mouse Y") * speedV;
        if (up_down > 30)
            up_down = 30;
        if (up_down < -60)
            up_down = -60;

        transform.eulerAngles = new Vector3(0.0f, left_right, up_down);
    }
}
