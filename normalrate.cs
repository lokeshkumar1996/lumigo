using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalrate : MonoBehaviour
{
    public void RAteuslick()
    {
        
        /// code for rating;
        
        //Application.OpenURL ("market://details?id=com.trollugames.caverun3d");
        //print("RateMe..........!!!!!" + Application.identifier);
        Application.OpenURL("market://details?id=" + Application.identifier);
        //Application.OpenURL("http://play.google.com/store/apps/details?id=" + Application.bundleIdentifier);
        PlayerPrefs.SetInt("rating",1);
        //PlayerPrefs.SetInt("diamonds",(PlayerPrefs.GetInt("diamonds") + 500 ));


        
    }
    public void supportme()
    {
        Application.OpenURL("https://www.patreon.com/playscape");
    }
}
