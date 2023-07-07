using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float pipespeed = 0f; //varaible for the the speed at which the pipe will move

    public float deadzone_position = -39.8f;  //where will pipe be destroyed


    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-pipespeed * Time.deltaTime, 0, 0); //we add to the original pipeposition a new vector 3 with -pipespped ( - cuz we the pipe will go left) on the x axis and time.deltatime is for it to run the same on differnt frame rates no matter the device

        if (transform.position.x <= deadzone_position)
        {
            Destroy(gameObject);                               //if pipe reach deazone then destroy the pipe (this is made to free up memory)
        }
    }
}
