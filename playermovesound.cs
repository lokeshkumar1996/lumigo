using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class playermovesound : MonoBehaviour
{
   

    bool setpitch = false;
    public AudioSource audioSource;
    public float pitch;
    
    void Awake()
    {
         audioSource = this.GetComponent<AudioSource>();

        //Initialize the pitch
        
       
         
    }
    void Start()
    {
        //Fetch the AudioSource from the GameObject
       //audioSource.loop = true;
       //audioSource.enabled = true;
       Invoke("enableaudio", 1f);
        

    }

    void Update()
    {   
       if (setpitch)
       {
       pitch = GameObject.Find("player").GetComponent<checkspeed>().speed;
        if(pitch > 3){pitch =3f;}
       audioSource.pitch= pitch;
       audioSource.volume = pitch; 
        }   
        
       
    }

    void enableaudio()
    {
    audioSource.enabled = true;
    setpitch = true;
    }

    

}
