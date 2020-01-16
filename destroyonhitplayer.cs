using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class destroyonhitplayer : MonoBehaviour

{

   
   
     bool gamehasended = false;
    public int pointscount = 0;
    public int health;
    float timebtwshots = 0;
    int scorelimit;

    
    GameObject  health1;    
    GameObject  health2;    
    GameObject  health3;
    
   


    public void Start()
    {
        Debug.Log("health"+ PlayerPrefs.GetInt("health"));

        health1 = GameObject.Find("healthinfo").transform.GetChild(2).gameObject;
        health2 = GameObject.Find("healthinfo").transform.GetChild(1).gameObject;
        health3 = GameObject.Find("healthinfo").transform.GetChild(0).gameObject;
        
        if(PlayerPrefs.GetInt("health") <= 0)
        {
          health = 1;
          PlayerPrefs.SetInt("health",health);
          health1.SetActive(true);
        }
        else if(PlayerPrefs.GetInt("health") >= 3)
        {
          health = 3;
          PlayerPrefs.SetInt("health",health);
           health1.SetActive(true);
            health2.SetActive(true);
             health3.SetActive(true);
        }
        else
        {
          health = PlayerPrefs.GetInt("health");
          PlayerPrefs.SetInt("health",health);
          if(health == 1)
          {
              health1.SetActive(true);
          }
          if(health == 2)
          {
            health1.SetActive(true);
            health2.SetActive(true);
          }
        }
        
       //  Debug.Log(PlayerPrefs.GetInt("health"));
      // PlayerPrefs.SetInt("health",3);
      scorelimit = GameObject.Find("timer").GetComponent<timer>().scorelimit; 
     

    }



    void Update()
    {
       health = PlayerPrefs.GetInt("health");

        if (timebtwshots <= 0)
        {
            gameObject.GetComponent<playermove>().enabled =true;     
        }else timebtwshots -= Time.deltaTime;


        if (pointscount >= scorelimit )
                  {   
                    if (gamehasended == false)
                      {
                       gamehasended = true;
                       levelcom();
                      }
                  }
       
        
    }

    // Start is called before the first frame update
   void OnCollisionEnter2D(Collision2D collision)
    {   
         if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "projectile" )
        {
            Vibration.Vibrate(160);
             health -= 1;
             FindObjectOfType<AudioManager>().Play("healthreduced");
            PlayerPrefs.SetInt("health",health);

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
          
          
              //Debug.Log(health);
            if(health <= 0)
            {    
              health1.SetActive(false);
              health2.SetActive(false);
              health3.SetActive(false);   
             //GameObject.Find("gamecontroller").GetComponent<gamecontroller>().EndGame()
             if (gamehasended == false)
                {
                gamehasended = true;
                
                //Invoke("Restart",2f);
                Restart();
                }
            }

             
        }  

        if (collision.gameObject.tag == "points" )
        {
           
            FindObjectOfType<AudioManager>().Play("pointscollected");
             pointscount = pointscount + 1;
             

                if (pointscount >= scorelimit )
                  {   
                    if (gamehasended == false)
                      {
                       gamehasended = true;
                       levelcom();
                      }
                  }
        } 
      

         if (collision.gameObject.tag == "slime")
         {

           FindObjectOfType<AudioManager>().Play("slimecontact");
            gameObject.GetComponent<playermove>().enabled =false;
            timebtwshots =  3f;      
         } 


         if (collision.gameObject.tag == "stone")
         {
            
           FindObjectOfType<AudioManager>().Play("healthreduced");
            gameObject.GetComponent<playermove>().enabled =false;
            timebtwshots =  .8f;      
         }    


    }

    
  

     public void Restart()
            {
              
            //gameObject.GetComponent<follow>().speed = 10; 
             FindObjectOfType<AudioManager>().Play("gameover");
            SceneManager.LoadScene("gameoveradd");            

            }

    void levelcom()
    {

      

      FindObjectOfType<AudioManager>().Play("levelcomplete");
            SceneManager.LoadScene("levelcomplete");
    }

     

    
}
