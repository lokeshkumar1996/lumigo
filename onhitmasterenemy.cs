using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class onhitmasterenemy : MonoBehaviour
{
    bool gamehasended = false;
    GameObject  health1;    
    GameObject  health2;    
    GameObject  health3;
    // Start is called before the first frame update
    void Start()
    {
        health1 = GameObject.Find("healthinfo").transform.GetChild(2).gameObject;
        health2 = GameObject.Find("healthinfo").transform.GetChild(1).gameObject;
        health3 = GameObject.Find("healthinfo").transform.GetChild(0).gameObject; 
    }
    
    // Start is called before the first frame update
   void OnCollisionEnter2D(Collision2D collision)
    {   
         if (collision.gameObject.tag == "enemy" )
        {
            
             FindObjectOfType<AudioManager>().Play("healthreduced");
            PlayerPrefs.SetInt("health",(PlayerPrefs.GetInt("health") -1));
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

             if(health <= 0)
            {     
                health1.SetActive(false);
                health2.SetActive(false);
             health3.SetActive(false);   
                Restart();
               
            }
        }   


        if (collision.gameObject.tag == "player" )
        {
            PlayerPrefs.SetInt("health",0);
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(false);  
             
             if (gamehasended == false)
                {
                gamehasended = true;
                
                
                Restart();
                }  
        } 
        
    }




    void Restart()
            {
            //gameObject.GetComponent<follow>().speed = 10; 
            FindObjectOfType<AudioManager>().Play("gameover"); 
            SceneManager.LoadScene("gameoveradd");            

            }
}

  
 
    
