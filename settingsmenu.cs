using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settingsmenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    // Start is called before the first frame update
   public void Setvolume(float volume)
   {
       audioMixer.SetFloat("volume", volume);
   }

   public void SetQuality( int qualityIndex)
   {
       QualitySettings.SetQualityLevel(qualityIndex);
   }

   public void Setbackgorund(float background)
   {
       audioMixer.SetFloat("background", background);
   }

   public void Seteffects(float effects)
   {
       audioMixer.SetFloat("effects", effects);
   }
}
