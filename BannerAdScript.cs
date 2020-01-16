using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAdScript : MonoBehaviour {

    public static BannerAdScript instance;

    string gameId = "3254985";
    string placementId = "unitybannerad";
    bool testMode = false;

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


    void Start () {
       Advertisement.Initialize (gameId, testMode);   //Advertisement.Initialize (gameId, testMode);  
       // Advertisement.Banner.SetPosition (BannerPosition.BOTTOM_CENTER);     
    } 
  



   public void showubannerad()
        {
         //  Debug.Log("scenechanged"+ PlayerPrefs.GetInt("scenechanged")); 
         //   StartCoroutine (ShowBannerWhenReady ());         
        Advertisement.Banner.SetPosition (BannerPosition.BOTTOM_CENTER);  
       
        
        StartCoroutine (ShowBannerWhenReady ());
       // Advertisement.Banner.Show (placementId);
        
       // Advertisement.Banner.Show (placementId);
        }

    public void hideubannerad()
        {
         Advertisement.Banner.Hide();
        }

    IEnumerator ShowBannerWhenReady () {
        while (!Advertisement.IsReady (placementId)) {
            yield return new WaitForSeconds (0.5f);
        }
        if(PlayerPrefs.GetInt("scenechanged")==1){
        Advertisement.Banner.Show (placementId);
        }
        yield break;
    }
       
    

       
}