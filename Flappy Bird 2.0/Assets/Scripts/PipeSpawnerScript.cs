using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe; //reference for the pipe prefab

    private float timer; //timer that counts up by time.deltatime

    public float heightoffset; // how many units it can go off the spawner

    public float lowestpoint; // minimum point that pipes can spawn

    public float highestpoint; // maximum point that pipes can spawn

    public float Spawnrate = 3; // when the timer reaches the spawnrate then a new pipe will spawn so basically spawnrate is how much time between each pipe

    public GameObject instantiatedobject; //refernce to the instantiated object (this is used in gameprogression script but the variable is assigned in this script)

    

    // Start is called before the first frame update
    private void Start()
    {
      
        SpawnPipe();  // spwan pipe as soon as the game starts

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Spawnrate)
        {
            timer = timer + Time.deltaTime;   //if the timer is less than the spawn rate then we increase it to make it the same as spawn rate
        }
        else
        {
            SpawnPipe();     // if otherwise so the timer is equal to the spawnrate then we spawn a pipe and restart the timer and this becomes a cycle
            timer = 0;
        }
    }

    // function that spawn pipe 
    void SpawnPipe()          
    {
        lowestpoint = transform.position.y - heightoffset;  // set value for lowest point where a pipe can spawn so we take the y position of the spawner and minus that by the offset

        highestpoint = transform.position.y + heightoffset; // set value for highest point where a pipe can spawn here we add instead of minus 

        instantiatedobject = Instantiate(pipe, new Vector3(transform.position.x , Random.Range(lowestpoint, highestpoint), transform.position.z), transform.rotation); // creates pipe in a random range between the lowest point and the highest point in the same rotation as the spawner also instantiated object variable will be set to every instantiated pipe
    }
}
