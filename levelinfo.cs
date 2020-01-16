using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelinfo : MonoBehaviour
{
    public GameObject levelinformation;
    public Text timecount;
    GameObject player;
    
    // Start is called before the first frame update
     public void levelinf()
    {
       // Debug.Log("resumepannel");
       //SceneManager.LoadScene("test4");
       player = GameObject.Find("player");
       levelinformation.SetActive(true);
       player.GetComponent<playermove>().enabled = false;

       if((GameObject.Find("levelcomplete") != null))
         {
          timecount.text = GameObject.Find("timer").GetComponent<timer>().endtime.ToString("0"); 
         }else  timecount.text = GameObject.Find("timer").GetComponent<timer>().elapsed.ToString("0"); 
        

       
        Time.timeScale = 0f; 
    }

    
    


    public void play()
    {
       //SceneManager.LoadScene("test4");
       if(AudioManager.instance.noads == 0)
             googleadmanager.instance.HideBanner();

        GameObject.Find("leveldetail").SetActive(false);
        Time.timeScale = 1f; 
        GameObject.Find("player").GetComponent<playermove>().enabled =true;  
    }

    
}
