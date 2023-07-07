using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //allows us to write <this>
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] Sounds;

    public static AudioManager instance; //a static variable is a variable that is shared by all instances of a class

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;        //if there is no audiomanager then add one and if there is then delete it   now all is for if we switch scenes we keep the same audio mananger
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
       foreach(Sound s in Sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();

            s.Source.clip = s.Audioclip;

            s.Source.pitch = s.Pitch;                                               //for each sound (s) in the Sounds array will have its own audio source made for it and we will copy the settings in the Sound and paste it into the settings of the source

            s.Source.volume = s.Volume;

            s.Source.loop = s.Loop;

            s.Source.playOnAwake = s.PlayOnAwake;
        }



    }

    private void Start()
    {
        Play("MainTheme");
    }



    public void Play(string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.Name == name); //<this>     this makes a refernce to a sound and we can specify which sound by typing the name ex: Play(Score)
        s.Source.Play(); //then play the sound from the sound source

    }

}
