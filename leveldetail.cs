using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class leveldetail : MonoBehaviour
{

    public GameObject addhealth;
    public GameObject buydiamonds;
    public GameObject buypanel;
    public GameObject fullhealth;
    public GameObject fullhelathtext;
    public GameObject addlifetext;
    GameObject  health1;    
    GameObject  health2;    
    GameObject  health3;
    public LevelDiamonddata l;

    // Start is called before the first frame update
   // Start is called before the first frame update

   void Start()
   {
     //if(AudioManager.instance.noads == 0)
            // googleadmanager.instance.RequestBanner();
             
     addhealth.SetActive(true);
     buydiamonds.SetActive(false);
     buypanel.SetActive(false);
     health1 = GameObject.Find("healthinfo").transform.GetChild(2).gameObject;
     health2 = GameObject.Find("healthinfo").transform.GetChild(1).gameObject;
     health3 = GameObject.Find("healthinfo").transform.GetChild(0).gameObject;

   }

  void Update()
  {
       if(fullhealth.activeSelf)
      {
        fullhelathtext.SetActive(true);
        addlifetext.SetActive(false);        
        addhealth.GetComponent<Button>().interactable = false;   
      } 
      else
      {
        fullhelathtext.SetActive(false);
        addlifetext.SetActive(true);
        addhealth.GetComponent<Button>().interactable = true;
      }

  }


    public void play()
    {
       //SceneManager.LoadScene("test4");
      // if(AudioManager.instance.noads == 0){
       //      googleadmanager.instance.HideBanner();
        //     Advertisement.Banner.Hide();}

        GameObject.Find("leveldetail").SetActive(false);
        Time.timeScale = 1f; 
        GameObject.Find("player").GetComponent<playermove>().enabled =true;

       
    }

     public void mainmenu()
        {
        //  if(AudioManager.instance.noads == 0){
         //    googleadmanager.instance.HideBanner();
          //   Advertisement.Banner.Hide();}

        Time.timeScale = 1f; 

          //Debug.Log("start");
       //  Destroy(GameObject.Find("Purchaser"));
         //Destroy(GameObject.Find("googladmanager"));
         if((GameObject.Find("descriptiontrans") != null))
         {
           Destroy(GameObject.Find("descriptiontrans"));
         }
         if((GameObject.Find("scenetransfer") != null))
         {
           Destroy(GameObject.Find("scenetransfer"));
         }
         SceneManager.LoadScene("menu1");
        

        }

         public void levelselect()
        {

        Time.timeScale = 1f; 
          //Debug.Log("start");
       //  Destroy(GameObject.Find("Purchaser"));
         //Destroy(GameObject.Find("googladmanager"));
         if((GameObject.Find("descriptiontrans") != null))
         {
           Destroy(GameObject.Find("descriptiontrans"));
         }
         if((GameObject.Find("scenetransfer") != null))
         {
           Destroy(GameObject.Find("scenetransfer"));
         }

          InterstitialAdsScript.instance.showuinterstitialad();   

         SceneManager.LoadScene("levelchose");       
        }

        public void addhealthclick()
        {

          
          int diamonds = AudioManager.instance.diamonds;

        if((diamonds - 100) >= 0)
        {
            //PlayerPrefs.SetInt("diamonds",diamonds-100);
            AudioManager.instance.diamonds =diamonds-100;
            l.leveldone = AudioManager.instance.leveldone;
            l.diamonds = AudioManager.instance.diamonds;
            l.savedata();

            PlayerPrefs.SetInt("health",(PlayerPrefs.GetInt("health") + 1 ));
            int health = PlayerPrefs.GetInt("health");
            
            if(health == 1)
          {
              health1.SetActive(true);
              health2.SetActive(false);
              health3.SetActive(false);

          }
          if(health == 2)
          {
              health1.SetActive(true);
              health2.SetActive(true);
              health3.SetActive(false);
          } 
          if(health == 3)
          {
              health1.SetActive(true);
              health2.SetActive(true);
              health3.SetActive(true);
          }
           
        }else
        {
          // show message;
          Debug.Log("not enough diamonds");
          addhealth.SetActive(false);
          buydiamonds.SetActive(true);  
        }
        
        }
}
