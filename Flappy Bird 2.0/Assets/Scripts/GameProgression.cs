using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgression : MonoBehaviour
{
      public PipeSpawnerScript pss; //reference to pipespawnerscript that would be assigned in unity by dragging the object that has the script to the field, unity will automatically find the script in that object

      private Transform bottom_pipe_transform; // transform variable that stores the bottom pipe transform

      public float timer; // timer that goes up by time.deltatime used to make the game harder as the player progreses through it

    public ButtonScript bs;

      


    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime; //we make the timer go up by time.deltatime

        if (timer >= 20)
        {
            pss.Spawnrate = 3.5f;    //if the  timer equal 15 then the spawn rate will decrease  therefore the game will be harder

        }


        if (timer >= 35)
        {
            pss.Spawnrate = 3f;    //if the timer equal 35 then the spawn rate will decrease  therefore the game will be harder 

        }


        bottom_pipe_transform = pss.instantiatedobject.transform.Find("Bottom pipe open"); //we set the bottompipetransform to the bottompipe which is a child of the instantiated object we found the child of the instantiated object by using transform.find and then typing what gameobject we wanna find

        if (bottom_pipe_transform != null && timer >= 45) 
       {
            bottom_pipe_transform.localPosition = new Vector3(0, -31 , 0);                    //if there is a bottom pipe and timer reached 50 then change the local position (local position is used to change the position of an object relative to its parent) to -31 on the y axis to make the distance between the bottom pipe and top pipe shorter therefore game will be harder

           

            
       }



        if (timer >= 55)
        {
            pss.RandomPipeArray = new GameObject[4];

            pss.RandomPipeArray[0] = pss.pipe;

            pss.RandomPipeArray[1] = pss.pipe;
                                                                                //for some reason i have to assign them all again 
            pss.RandomPipeArray[2] = pss.ClosedPipe;

            pss.RandomPipeArray[3] = pss.ClosedPipe;

        }

        bs = pss.instantiatedobject.transform.Find("Button").GetComponent<ButtonScript>();

        if (timer >= 70)
        {

            bs.OpeningLength = 10f;
        }
    }
}
