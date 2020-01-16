using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;


public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Sound[] sounds;
    public static AudioManager instance;
    public AudioMixerGroup effectsMixer;

    public int leveldone;
    public int diamonds;
    public int noads;
    public int ReferalClaimed;
    public int otherreferalclaimed;
    
    void Awake()
    {
       // Application.targetFrameRate = 60;

        if(instance == null)
            instance =this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

      foreach(Sound s in sounds)  
      {
          s.source = gameObject.AddComponent<AudioSource>();
          s.source.outputAudioMixerGroup = effectsMixer;
          s.source.clip =s.clip;

          s.source.volume = s.volume;
          s.source.pitch = s.pitch;
          s.source.loop = s.loop;
      } 
    }

   


    // Update is called once per frame
  

    public void Play(string name)
    {
       Sound s = Array.Find(sounds, sound => sound.name == name);
       if(s==null)
       {
           Debug.Log("Sound: " + name + "notfound");
           return;
       }
       s.source.Play(); 
    }

    
}
 