using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class levelcomplete : MonoBehaviour
{
   int currentlevel;
   float timetocomplete;
   float star3 = 25f;
   float star2 = 40f;
   int levelstar = 1;
   int levelind;   
   public GameObject diamondanimation;
   public GameObject glowstar1;
   public GameObject glowstar2;
   public GameObject glowstar3;
   public GameObject glowstar4;
   public GameObject glowstar5;
   public GameObject glowstar6;
   public GameObject health1;
   public GameObject health2;
   public GameObject health3;
   public LevelDiamonddata l;
   public Text levelcount;
   int health;
 

  

   void Start()
   {  

      if(AudioManager.instance.noads == 0)            
             BannerAdScript.instance.showubannerad();

             
       levelind = ((GameObject.Find("scenetransfer").GetComponent<scenetransfer>().levelind)); 
       levelcount.text = levelind.ToString("00");

         health = GameObject.Find("scenetransfer").GetComponent<scenetransfer>().health; 
       timetocomplete = GameObject.Find("scenetransfer").GetComponent<scenetransfer>().timeended;       
     
      
      Destroy(GameObject.Find("scenetransfer"));


     if(health >= 3)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
        }
        if(health==2)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(false);
        }
         if(health ==1)
        {
            health1.SetActive(true);
            health2.SetActive(false);
            health3.SetActive(false);
        }
         if(health <=0)
        {
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(false);
        }

      
    // if(levelind % 3 == 0){
   //   if(AudioManager.instance.noads == 0)
    //  InterstitialAdsScript.instance.showuinterstitialad();   
   //  }


    if (timetocomplete <= star3)
        {
           levelstar = 3;
           glowstar4.SetActive(true);
            glowstar5.SetActive(true);
             glowstar6.SetActive(true);

            string levelindstring = levelind.ToString("0");

            if(PlayerPrefs.HasKey(levelindstring) == true && PlayerPrefs.GetInt(levelindstring) != 3 )
            {
                            
               diamondanimation.SetActive(true);
                adddiamond();
              
            }
            else if(PlayerPrefs.HasKey(levelindstring) == false )
            {
                                        
               diamondanimation.SetActive(true);
               adddiamond();
               
               
            }else if(PlayerPrefs.HasKey(levelindstring) == true && PlayerPrefs.GetInt(levelindstring) == 3)
            {
                          
               diamondanimation.SetActive(false);
                  
               
            }
           
        }

        if (timetocomplete > star3 && timetocomplete <= star2)
        {
           levelstar = 2;
           diamondanimation.SetActive(false);
           glowstar2.SetActive(true);
           glowstar3.SetActive(true);
           
        }
        if (timetocomplete > star2 )
        {
           levelstar = 1;
           diamondanimation.SetActive(false);
           glowstar6.SetActive(true);
        }


    

   }

 


    

    


    public void adddiamond()
    {
       
       
      // PlayerPrefs.SetInt("diamonds",PlayerPrefs.GetInt("diamonds") + 100);

        AudioManager.instance.diamonds = AudioManager.instance.diamonds + 100;
           
            l.diamonds = AudioManager.instance.diamonds;            
            l.leveldone = AudioManager.instance.leveldone;
            l.savedata();
      

    }


  
    // Start is called before the first frame update
  public void nextlvl()
      {
       
      // levelno = string.Concat(SceneManager.GetActiveScene().name[5], SceneManager.GetActiveScene().name[6]); 
       currentlevel = levelind;
       string currentlevelstring = currentlevel.ToString("0");
         //int leveldone = PlayerPrefs.GetInt("leveldone");
           int leveldone = AudioManager.instance.leveldone;

       
        
      
         if (currentlevel >= leveldone)
         {
           AudioManager.instance.leveldone = currentlevel;
           
           l.leveldone = currentlevel;
           l.savedata();
         //PlayerPrefs.SetInt("leveldone",currentlevel);
         PlayerPrefs.SetInt(currentlevelstring,levelstar);
         }else {PlayerPrefs.SetInt(currentlevelstring,levelstar);}
       

      

         if(AudioManager.instance.noads == 0){
              //googleadmanager.instance.HideBanner();
            BannerAdScript.instance.hideubannerad();}
          

         if(currentlevel % 3 == 0){
         if(AudioManager.instance.noads == 0)           
         InterstitialAdsScript.instance.showuinterstitialad();            
         }

        if(currentlevel == 80) 
        { 
           AudioManager.instance.leveldone = currentlevel;
           l.leveldone = currentlevel;
           l.savedata();
           SceneManager.LoadScene("credits"); }
        else { SceneManager.LoadScene((levelind+1)*2); }
       
    }


   public void retrysamelevel()
    {
      if(AudioManager.instance.noads == 0)
            BannerAdScript.instance.hideubannerad();
             
      SceneManager.LoadScene(levelind*2);

    }

    

     

}
