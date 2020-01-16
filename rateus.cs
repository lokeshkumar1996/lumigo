using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rateus : MonoBehaviour
{
    public GameObject ratingpannel;
    public LevelDiamonddata l;
    // Start is called before the first frame update
    public void RAteuslick()
    {
        
        /// code for rating;
        ratingpannel.SetActive(false);
        //Application.OpenURL ("market://details?id=com.trollugames.caverun3d");
        //print("RateMe..........!!!!!" + Application.identifier);
        Application.OpenURL("market://details?id=" + Application.identifier);
        //Application.OpenURL("http://play.google.com/store/apps/details?id=" + Application.bundleIdentifier);
        PlayerPrefs.SetInt("rating",1);

        
        int totaldiamonds = AudioManager.instance.diamonds;
            totaldiamonds  = totaldiamonds + 500;
            l.diamonds = totaldiamonds;
            AudioManager.instance.diamonds = l.diamonds;
            l.leveldone = AudioManager.instance.leveldone;
            l.savedata();
            FindObjectOfType<AudioManager>().Play("purchased");


        
    }


    public void supportme()
    {
        Application.OpenURL("https://www.patreon.com/playscape");
    }

    public void remindmlater()
    {
        ratingpannel.SetActive(false);
       GameObject.Find("rateustimer").GetComponent<rateustimer>().timer = 0f;

    }

}
