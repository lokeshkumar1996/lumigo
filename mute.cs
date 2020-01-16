using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class mute : MonoBehaviour
{
    public Toggle speaker;
    public AudioMixer audioMixer;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("mute",0) == 1)
        {
            speaker.isOn = false;
        }else speaker.isOn = true;
        onchangevaluespeaker();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onchangevaluespeaker()
    {

        if(speaker.isOn == true)
        {
            PlayerPrefs.SetInt("mute",0);
        
        audioMixer.SetFloat("background", PlayerPrefs.GetFloat("bgvol", -10));
        audioMixer.SetFloat("effects", PlayerPrefs.GetFloat("sfxvol", -10));
        audioMixer.SetFloat("volume", PlayerPrefs.GetFloat("mastervol", 0));
                        
        }
        else
        {  
            PlayerPrefs.SetInt("mute",1);       
        audioMixer.SetFloat("background", -60);        
        audioMixer.SetFloat("effects", -60);
        audioMixer.SetFloat("volume", -60);
            
        }
    }
}
