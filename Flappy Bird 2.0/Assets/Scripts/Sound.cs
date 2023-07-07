using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound //we dont want it to be monobehavior because we are not attaching the script to any game object
{

    public string Name;

    public AudioClip Audioclip;

    [Range(0f,1f)]
    public float Volume;                                 //settings for our sound

    [Range(0.1f,3f)]
    public float Pitch;

    public bool PlayOnAwake;

    public bool Loop;

    [HideInInspector]
    public AudioSource Source;
   


}
