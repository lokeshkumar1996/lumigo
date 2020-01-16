using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class googleadmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public static googleadmanager instance;
    


    private string appID = "ca-app-pub-8290007668929325~8105324760";

    private BannerView bannerView;
    private string bannerID = "ca-app-pub-3940256099942544/6300978111";  // test
    //private string bannerID = "ca-app-pub-8290007668929325/3324250307"; // orginal


    private InterstitialAd fullScreenAd;
    private string fullScreenAdID = "ca-app-pub-3940256099942544/1033173712"; // test
    //private string fullScreenAdID = "ca-app-pub-8290007668929325/3136887351"; // orginal


   
    
    private void Awake()
    {
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

    private void Start()
    {
   // RequestFullScreenAd();

        MobileAds.Initialize(appID);
       // RequestFullScreenAd();

    }


    public void RequestBanner()
    {
        //BannerAdScript.instance.showubannerad();

        bannerView = new BannerView(bannerID, AdSize.Banner, AdPosition.Bottom);        
        this.bannerView.OnAdFailedToLoad += this.HandleOnAdFailedToLoad;
        this.bannerView.OnAdLoaded += this.HandleOnAdLoaded;
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
       //bannerView.Show();
    }
   

    public void HideBanner()
    {
        bannerView.Hide();
    }

     public void ShowBanner()
    {
        bannerView.Show();
    }    



    public void RequestFullScreenAd()
    {
        fullScreenAd = new InterstitialAd(fullScreenAdID);
        AdRequest request = new AdRequest.Builder().Build();
        fullScreenAd.LoadAd(request);
    }

    public void ShowFullScreenAd()
    {
        if(fullScreenAd.IsLoaded())        
        {
            fullScreenAd.Show();
           // RequestFullScreenAd();

        }
        else
        {
           // Debug.Log("full screen ad not loaded");
            //unity add
            InterstitialAdsScript.instance.showuinterstitialad();   
            //RequestFullScreenAd();
        }

    }


    //bannerview load check
    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
      //  MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
      //                      + args.Message);

        BannerAdScript.instance.showubannerad();
    }
    //banner on load
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
       // MonoBehaviour.print("HandleAdLoaded event received");
        bannerView.Show();
    }








    



  
       



}
