using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;
using UnityEngine.Advertisements;

using UnityEngine.SceneManagement;

public class googlerewardedadmanager : MonoBehaviour
{
    // Start is called before the first frame update
    //public static googleadmanager instance;
    //public GameObject samelevel;
   // public GameObject addicon;
    public GameObject text;
    bool networkon;
    public LevelDiamonddata l;
    


    private string appID = "ca-app-pub-8290007668929325~8105324760";
    

    private RewardBasedVideoAd rewardedAd;
    private string rewardedAdID = "ca-app-pub-3940256099942544/5224354917";  //test
    //private string rewardedAdID = "ca-app-pub-8290007668929325/1823805688"; // orginal
    
    
   

    private IEnumerator Start ()
    {
        
   
        
        while (Application.internetReachability == NetworkReachability.NotReachable) 
        {
            yield return null;
            Debug.Log("no nework");
            text.SetActive(true);
            networkon = false;
        }
        //yield return new WaitForSeconds(1.5f);

           this.rewardedAd = RewardBasedVideoAd.Instance;
           // this.rewardedAd = new RewardedAd(rewardedAdID);
            Debug.Log("newtork available");
            text.SetActive(false);
            networkon = true;
            
              
      
            rewardedAd.OnAdRewarded += HandleRewardBasedVideoRewarded;     

            rewardedAd.OnAdClosed += HandleRewardBasedVideoClosed;
            rewardedAd.OnAdLeavingApplication += HandleRewardBasedVideoLeftApplication;    
            rewardedAd.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad;
    
            rewardedAd.OnAdStarted += HandleRewardBasedVideoStarted;
            this.RequestRewardedAd();  
    }


    


    public void RequestRewardedAd()
    {
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request, rewardedAdID);
      
    }

    public void ShowRewardedVideoAd()
    {

        if(AudioManager.instance.noads == 0){
             googleadmanager.instance.HideBanner();
             Advertisement.Banner.Hide();}

        if(networkon)
        {
             if(rewardedAd.IsLoaded())
             {
             rewardedAd.Show();
             }
             else
             {               
                //GameObject.Find("unityrewardedad").GetComponent<admanager>().ShowAdrewarded ();                
             
             }
        }
    }

    public void HandleRewardBasedVideoRewarded(object sender, Reward args)
    {
        //addicon.SetActive(false);
        //samelevel.SetActive(true); 
       string type = args.Type;
       double amount = args.Amount;

        //PlayerPrefs.SetInt("diamonds",(PlayerPrefs.GetInt("diamonds") + 100));
        AudioManager.instance.diamonds = AudioManager.instance.diamonds + 100;
            l.leveldone = AudioManager.instance.leveldone;
            l.diamonds = AudioManager.instance.diamonds;
            l.savedata();
       // Debug.Log("you have been rewarded with " + amount.ToString() + type);
        //action
        GameObject.Find("restartmanager").GetComponent<restartmenu>().restartsamelevelfulllife();
                

    }


    public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
    {
        //addicon.SetActive(true);
        //samelevel.SetActive(false);
        this.RequestRewardedAd();
    }

    public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLeftApplication event received");
       // addicon.SetActive(false);
       // samelevel.SetActive(true);        
        
    }

    public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardBasedVideoFailedToLoad event received with message: "
                             + args.Message);
        GameObject.Find("unityrewardedad").GetComponent<admanager>().ShowAdrewarded();
    }

     public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
       // addicon.SetActive(false);
        //samelevel.SetActive(true);    

    }



   

       



}
