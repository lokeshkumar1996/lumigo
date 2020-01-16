using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;
using UnityEngine.SceneManagement;
//using UnityEngine.Advertisements;

public class admanager : MonoBehaviour { 

    //public static admanager instance;

   

    //string gameId = "3254985";
    //bool testMode = true;
    public LevelDiamonddata l;
    public GameObject text;
    bool networkon;
    

    private string rewarded_ad = "rewardedVideo";
    
    

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
           // this.rewardedAd = new RewardedAd(rewardedAdID);
            Debug.Log("newtork available");
            text.SetActive(false);
            networkon = true;
    }


    /* public void rewardedvideoclick(){
        if (Monetization.IsReady(rewarded_ad)){
            ShowAdPlacementContent ad = null;
            ad= Monetization.GetPlacementContent(rewarded_ad) as ShowAdPlacementContent;

            if(ad != null){
                ad.Show();
            }
        }
    }

   void Update(){

        if(Input.GetKeyDown(KeyCode.R))
        {
          if (Monetization.IsReady(rewarded_ad))
          {
            ShowAdPlacementContent ad = null;
            ad= Monetization.GetPlacementContent(rewarded_ad) as ShowAdPlacementContent;

            if(ad != null)
                ad.Show();
          }
        }
        }*/



    



    
    public void ShowAdrewarded () {
        if(networkon == true){
        ShowAdCallbacks options = new ShowAdCallbacks ();
        options.finishCallback = HandleShowResult;
        ShowAdPlacementContent ad = Monetization.GetPlacementContent (rewarded_ad) as ShowAdPlacementContent;
        ad.Show (options);
        }
    }

   public void HandleShowResult (ShowResult result) {
        if (result == ShowResult.Finished)
         {            //reward
        AudioManager.instance.diamonds = AudioManager.instance.diamonds + 100;
            l.leveldone = AudioManager.instance.leveldone;
            l.diamonds = AudioManager.instance.diamonds;
            l.savedata();
        GameObject.Find("restartmanager").GetComponent<restartmenu>().restartsamelevelfulllife();
        }
         else if (result == ShowResult.Skipped) {             
            Debug.LogWarning ("The player skipped the video - DO NOT REWARD!");
        } else if (result == ShowResult.Failed) {
            Debug.LogError ("Video failed to show");
            //ShowAdrewarded ();
        }
    }

}
