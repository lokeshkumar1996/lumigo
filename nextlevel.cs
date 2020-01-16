using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using UnityEngine.Monetization;

public class nextlevel : MonoBehaviour
{
     string decno;
     int currdec;
     public bool goclick = false;
     //public GameObject dectext;
     
     void Start()
     {
         if (GameObject.Find("scenetransfer") != null)
           {
          Destroy(GameObject.Find("scenetransfer"));
          }

          

          
            
           if(AudioManager.instance.noads == 0)            
             BannerAdScript.instance.showubannerad();
           

            
            
                    
      
        decno = string.Concat(SceneManager.GetActiveScene().name[3], SceneManager.GetActiveScene().name[4]);
        currdec = int.Parse(decno);

         StartCoroutine(LoadScenenextlevel());

     }

      

    
   
     
     
     
     
     public void nextlvl()
    {
      
           if(AudioManager.instance.noads == 0){
              //googleadmanager.instance.HideBanner();
            BannerAdScript.instance.hideubannerad();}
          
         goclick = true;
    }

    

      



    IEnumerator LoadScenenextlevel()
    {
        yield return null;

        //Begin to load the Scene you specify
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync((currdec * 2) + 1 );
        //Don't let the Scene activate until you allow it to
        asyncOperation.allowSceneActivation = false;
       // Debug.Log("Pro :" + asyncOperation.progress);
        //When the load is still in progress, output the Text and progress bar
        while (!asyncOperation.isDone)
        {
            // Check if the load has finished
            if (asyncOperation.progress >= 0.9f)
            {
                //Change the Text to show the Scene is ready
              // Debug.Log(goclick);
                //Wait to you press the space key to activate the Scene
                if (goclick == true)
                    //Activate the Scene
                    asyncOperation.allowSceneActivation = true;
            }

            yield return null;
        }
    }



    public void levelselect()
        {   
        
        Destroy(GameObject.Find("descriptiontrans"));
       //  Destroy(GameObject.Find("googladmanager"));
        // Destroy(GameObject.Find("googlerewardedadmanager"));
       // if(PlayerPrefs.GetInt("noads") == 0)
       // googleadmanager.instance.HideBanner();
            
          if(AudioManager.instance.noads == 0){
              //googleadmanager.instance.HideBanner();
            BannerAdScript.instance.hideubannerad();}

           //InterstitialAdsScript.instance.showuinterstitialad(); 

            
                       
         
       
        SceneManager.LoadScene("levelchose");  

        }

    
}
