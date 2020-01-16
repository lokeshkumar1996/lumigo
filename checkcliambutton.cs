using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class checkcliambutton : MonoBehaviour
{

    public Slider sfx;
    public Slider mastervol;
    public Slider bgvol;
    public GameObject cliambutton;    
    public Dropdown graphic;
    public Toggle speaker;
    public Toggle border;
    public AudioMixer audioMixer;
    //public ReferalPurchasedata p;

    // Start is called before the first frame update
    void Start()
    {
        if(AudioManager.instance.ReferalClaimed == 1 || AudioManager.instance.otherreferalclaimed != 0)
        {
        cliambutton.SetActive(false);
        }else cliambutton.SetActive(true);
        
        graphic.value = PlayerPrefs.GetInt("graphicsquality", 0);

         if(PlayerPrefs.GetInt("border",0)== 0)
        {
          border.isOn = false;
        }else  border.isOn = true;

        if(PlayerPrefs.GetInt("mute",0) == 1)
        {
            speaker.isOn = false;
        }else speaker.isOn = true;



        if(speaker.isOn == true)
        {
        sfx.interactable = true;
        mastervol.interactable = true;
        bgvol.interactable = true;    
        sfx.value =  PlayerPrefs.GetFloat("sfxvol", -10);
        mastervol.value =  PlayerPrefs.GetFloat("mastervol", 0);
        bgvol.value =  PlayerPrefs.GetFloat("bgvol", -10);
        audioMixer.SetFloat("background", bgvol.value);
        audioMixer.SetFloat("effects", sfx.value);
        audioMixer.SetFloat("volume", mastervol.value);
        }
        else
        {
        //sfx.value =  sfx.minValue;
        audioMixer.SetFloat("background", -60);
        sfx.interactable = false;
        audioMixer.SetFloat("effects", -60);
        //mastervol.value = mastervol.minValue;
        mastervol.interactable = false;
        audioMixer.SetFloat("volume", -60);
        //bgvol.value = bgvol.minValue;
        bgvol.interactable = false;
       
        }


        

        if(graphic.value == 0)
        {
                #if UNITY_ANDROID 
     
            Application.targetFrameRate = 60;
            //QualitySettings.vSyncCount = 1;
           
             //QualitySettings.vSyncCount = 0;
           
            // QualitySettings.antiAliasing = 0;
           
             Screen.sleepTimeout = SleepTimeout.NeverSleep;
     
                #endif
                QualitySettings.SetQualityLevel(0);
        }

          if(graphic.value == 1)
        {
                #if UNITY_ANDROID 
     
             //Application.targetFrameRate = 30;
             QualitySettings.vSyncCount = 1;
           
             //QualitySettings.vSyncCount = 0;
           
             //QualitySettings.antiAliasing = 0;
           
             Screen.sleepTimeout = SleepTimeout.NeverSleep;
     
                #endif
                QualitySettings.SetQualityLevel(1);
        }
    }

    // Update is called once per frame
    

    public void onchangevaluesfx()
    {
        PlayerPrefs.SetFloat("sfxvol", sfx.value); 
        audioMixer.SetFloat("effects", sfx.value);       
    }
    public void onchangevaluebg()
    {
       
        PlayerPrefs.SetFloat("bgvol", bgvol.value);
        audioMixer.SetFloat("background", bgvol.value);
    }
    public void onchangevaluemaster()
    {
        float vol = mastervol.value;
        PlayerPrefs.SetFloat("mastervol", vol);
        audioMixer.SetFloat("volume", mastervol.value);
    }

    public void onchangevaluegraphics()
    {
               PlayerPrefs.SetInt("graphicsquality", graphic.value);
               QualitySettings.SetQualityLevel(graphic.value);
    }

    public void onchangevaluespeaker()
    {

        if(speaker.isOn == true)
        {
            PlayerPrefs.SetInt("mute",0);
        sfx.interactable = true;
        mastervol.interactable = true;
        bgvol.interactable = true;
        sfx.value =  PlayerPrefs.GetFloat("sfxvol", -10);
        mastervol.value =  PlayerPrefs.GetFloat("mastervol", 0);
        bgvol.value =  PlayerPrefs.GetFloat("bgvol", -10);
        audioMixer.SetFloat("background", bgvol.value);
        audioMixer.SetFloat("effects", sfx.value);
        audioMixer.SetFloat("volume", mastervol.value);
                        
        }
        else
        {  
            PlayerPrefs.SetInt("mute",1);
        //sfx.value =  sfx.minValue;
        audioMixer.SetFloat("background", -60);
        sfx.interactable = false;
        audioMixer.SetFloat("effects", -60);
        //mastervol.value = mastervol.minValue;
        mastervol.interactable = false;
        audioMixer.SetFloat("volume", -60);
        //bgvol.value = bgvol.minValue;
        bgvol.interactable = false;       
        }
    }

    public void onchangevalueborder()
    {

        if(border.isOn == true)
        {
           PlayerPrefs.SetInt("border",1);         
        }
        else
        {  
           PlayerPrefs.SetInt("border",0);         
        }       
        
    }


}
