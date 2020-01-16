using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Advertisements;
using UnityEngine.Monetization;

public class InterstitialAdsScript : MonoBehaviour 
{ 
    public static InterstitialAdsScript instance;

    string gameId = "3254985";
   bool testMode = false;
   
   
    private string interstitial_ad = "video";
   
    // Initialize the Ads service:

    private void Awake()
    {
        Monetization.Initialize (gameId, testMode);
         if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
      DontDestroyOnLoad(this);
    }

    void Start () {
        //Advertisement.Initialize (gameId, testMode);
       
       
       // Advertisement.Show ();
        Debug.Log("ads shown");
        
    }

      
  /*    void Update(){

        if(Input.GetKeyDown(KeyCode.V))
        {
          if (Monetization.IsReady(interstitial_ad))
          {
            ShowAdPlacementContent ad = null;
            ad= Monetization.GetPlacementContent(interstitial_ad) as ShowAdPlacementContent;

            if(ad != null)
                ad.Show();
          }
        }
        }*/

        public void showuinterstitialad()
        {
            ShowAdPlacementContent ad = null;
            ad= Monetization.GetPlacementContent(interstitial_ad) as ShowAdPlacementContent;

            if(ad != null)
                ad.Show();
        }

        

    
}
