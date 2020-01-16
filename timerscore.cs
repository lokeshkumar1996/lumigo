using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timerscore : MonoBehaviour
{
    // Start is called before the first frame update
     public Text timercount;
    float endtime;
    GameObject timer;
    int health;
    int healthcheck;
    int finalhealth;
    //public GameObject levelcomplete;
    void Start()
    {
      healthcheck = PlayerPrefs.GetInt("health");
       timer = GameObject.Find("timer");

       if(healthcheck <= 0)
        {
          health = 1; 
        }
        else if(healthcheck >= 3)
        {
          health = 3;  
        }
        else
        {
          health = healthcheck;
        }
        
    }

    void FixedUpdate()
    {   
      
      
     
      if(timer.GetComponent<timer>().elapsed >= timer.GetComponent<timer>().timerend)
      {     
            if(health != GameObject.Find("player").GetComponent<destroyonhitplayer>().health)
            {
                timer.GetComponent<timer>().timerend = 19f;
                Destroy(GameObject.Find("timer"));
            }
            
            FindObjectOfType<AudioManager>().Play("levelcomplete");
            SceneManager.LoadScene("levelcomplete");  
           
          

      }
      else  timercount.text = timer.GetComponent<timer>().elapsed.ToString("00");   


    

      
    }
}
