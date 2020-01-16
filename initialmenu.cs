using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class initialmenu : MonoBehaviour
{   
    public GameObject networkcheckpanel;
    public Button startbut;
    public LevelDiamonddata l;
    public ReferalPurchasedata p;

    // Start is called before the first frame update
     private IEnumerator Start () 
    {   
       // PlayerPrefs.SetInt("leveldone",5);
        //PlayerPrefs.SetInt("diamonds",100); 
       // PlayerPrefs.SetInt("initialmenu",1);
        
        startbut.interactable = false;
        while (Application.internetReachability == NetworkReachability.NotReachable) 
        {
            yield return null;
            Debug.Log("no nework");
            networkcheckpanel.SetActive(true);            
        }

        //for update remove      
        PlayerPrefs.DeleteAll(); 

        PlayerPrefs.Save();
        //forupdate
        //

        GameObject.Find("createreferal").GetComponent<createreferalcode>().enabled = true; 
        yield return new WaitForSeconds(2f);   
       //Debug.Log(PlayerPrefs.GetString("ReferalCode"));
        //Debug.Log("RateMe..........!!!!!" + Application.identifier);
        /*
        PlayerPrefs.SetInt("leveldone",0);
        PlayerPrefs.SetInt("diamonds",100);    

        PlayerPrefs.SetInt("noads",0);
        PlayerPrefs.SetInt("ReferalClaimed", 0); //tounlock levels
        PlayerPrefs.SetInt("otherreferalclaimed", 0);//to lok claim button
         
        */
        PlayerPrefs.SetInt("health",3);
        

        l.leveldone = 0;
        l.diamonds = 100;
        l.savedata();
        p.noads = 0;
        p.ReferalClaimed = 0;
        p.otherreferalclaimed = 0;
        p.savedata();

        AudioManager.instance.leveldone = l.leveldone;
        AudioManager.instance.diamonds = l.diamonds;        
        AudioManager.instance.noads = p.noads;
        AudioManager.instance.ReferalClaimed = p.ReferalClaimed;
        AudioManager.instance.otherreferalclaimed = p.otherreferalclaimed;        

        startbut.interactable = true;
        
        //language = "english";
        
    }

    
    
   
    // Update is called once per frame
   public  void startbutton()
    {
        PlayerPrefs.SetInt("initialmenu",1);
        PlayerPrefs.SetInt("logomenu",1);
        SceneManager.LoadScene("menu1");

    }
}
