using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playeroutsidecheck : MonoBehaviour
{
    public int limitdist;
    float followspeed;
    public GameObject followobject;
    int health;
    bool gamehasended = false;
    
   
   
   


    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = followobject.transform;
    }
    
    void FixedUpdate()
    {
      // GameObject.Find("bubble").GetComponent<AudioSource>().Play();
    
    if(Vector2.Distance(transform.position, target.position) > limitdist)
      {
      //GameObject.Find("gamecontroller").GetComponent<gamecontroller6>().endgame();
      health = PlayerPrefs.GetInt("health");
      FindObjectOfType<AudioManager>().Play("healthreduced");
      health -= 1;
      PlayerPrefs.SetInt("health",health);
      if(health <= 0)
            {          
             //GameObject.Find("gamecontroller").GetComponent<gamecontroller>().EndGame()
             if (gamehasended == false)
                {
                gamehasended = true;
                
                Invoke("Restart",2f);
                Restart();
                }
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
