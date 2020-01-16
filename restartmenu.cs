using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class restartmenu : MonoBehaviour
{
    public int levelindcator;
    //public int levelpushback;
   // public int score;
   // public float endtime;
  //  int endtimeint;
   
    //public Text scorecount;
    //public Text levelcount;
    //public Text timecount;
    //public Text availadiamonds;
   public GameObject errorpannel;
    public GameObject revivebutton;
    public GameObject skipbutton;
    public GameObject addbutton;
    public GameObject noadsretrybutton;
    public LevelDiamonddata l;


 
    

    public void Awake()
    {
        //toshow banner add
        PlayerPrefs.SetInt("health", 0 );   

        if(AudioManager.instance.noads == 0)
        {
         BannerAdScript.instance.showubannerad();
         addbutton.SetActive(true);
         noadsretrybutton.SetActive(false);

        }
        else
        {
          addbutton.SetActive(false);
          noadsretrybutton.SetActive(true);
        }
        
        //

        Debug.Log("scenetransfer");
       levelindcator = ((GameObject.Find("scenetransfer").GetComponent<scenetransfer>().levelind)) ;
       // score = GameObject.Find("scenetransfer").GetComponent<scenetransfer>().score;
      //  endtime = GameObject.Find("scenetransfer").GetComponent<scenetransfer>().timeended;
      //  endtimeint = (int)endtime;

       Destroy(GameObject.Find("scenetransfer"));
        errorpannel.SetActive (false); 

        

        //on second entry dispaly skip button
        
        if((PlayerPrefs.GetInt("levellost")) == levelindcator)
        {
            if(PlayerPrefs.GetInt("levellost1") == PlayerPrefs.GetInt("levellost"))
            {
              skipbutton.SetActive(true);
              revivebutton.SetActive(false);
            }
            else
            {
              PlayerPrefs.SetInt("levellost1",levelindcator);
              skipbutton.SetActive(false);
              revivebutton.SetActive(true);
            }
        }
        else
        {
          PlayerPrefs.SetInt("levellost",levelindcator);
           skipbutton.SetActive(false);
           revivebutton.SetActive(true);
        }
    }



    // Start is called before the first frame update
   


    public void restartsamelevel()
     {
            // to hide banner add    
           if(AudioManager.instance.noads == 0){
              //googleadmanager.instance.HideBanner();
            BannerAdScript.instance.hideubannerad();}

            // to hide banner add
            PlayerPrefs.SetInt("health", 1 );           
                      
            SceneManager.LoadScene(levelindcator * 2);
        
    } 

    public void restartsamelevelfulllife()
     {
            // to hide banner add    
          if(AudioManager.instance.noads == 0){
              //googleadmanager.instance.HideBanner();
            BannerAdScript.instance.hideubannerad();}

            // to hide banner add
            PlayerPrefs.SetInt("health", 3 );
            
            SceneManager.LoadScene(levelindcator * 2);        
    }


    public void menu()
    {
       
         if(AudioManager.instance.noads == 0){
             // googleadmanager.instance.HideBanner();
            BannerAdScript.instance.hideubannerad();}
         
       
        SceneManager.LoadScene("menu1");  

    }

   
    public void getfulllife()
    {   
        
        int diamonds = AudioManager.instance.diamonds;

        if((diamonds - 400) >= 0)
        {
           // PlayerPrefs.SetInt("diamonds",diamonds-400);
            AudioManager.instance.diamonds = diamonds-400;
            l.leveldone = AudioManager.instance.leveldone;
            l.diamonds = AudioManager.instance.diamonds;
            l.savedata();
           
            restartsamelevelfulllife();


        }else
        {
          // show message;
          Debug.Log("not enough diamonds");
          errorpannel.SetActive (true); 
         // availadiamonds.text = diamonds.ToString("0");

        }
        
    }

    public void gotoselectmenu()
    {
       if(AudioManager.instance.noads == 0){
             //googleadmanager.instance.HideBanner();
            BannerAdScript.instance.hideubannerad();}

            InterstitialAdsScript.instance.showuinterstitialad();  
        
        SceneManager.LoadScene("levelchose");  
    }


    public void skiplevelbutton()
    {
       if(AudioManager.instance.noads == 0){
              //googleadmanager.instance.HideBanner();
            BannerAdScript.instance.hideubannerad();}

      if(levelindcator == 80) { SceneManager.LoadScene("menu1"); }
        else
         {  
           int diamonds = AudioManager.instance.diamonds;;

            if((diamonds - 800) >= 0)
            {
            //PlayerPrefs.SetInt("diamonds",diamonds-800);
            

            
             string currentlevelstring = levelindcator.ToString("0");
             //PlayerPrefs.SetInt("leveldone",levelindcator);
            PlayerPrefs.SetInt(currentlevelstring,0);
            AudioManager.instance.diamonds = diamonds-800;
            l.leveldone = levelindcator;
            AudioManager.instance.leveldone = levelindcator;
            l.diamonds = AudioManager.instance.diamonds;
            l.savedata();
            PlayerPrefs.SetInt("health", 3 );

             SceneManager.LoadScene((levelindcator+1)*2); 

            }
            else
            {
          // show message;
           Debug.Log("not enough diamonds");
           errorpannel.SetActive (true); 
          //availadiamonds.text = diamonds.ToString("0");
           }
         }
    }
     

     public void noadretrybutton()
     {
       restartsamelevelfulllife();
     }
}
