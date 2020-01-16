using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class destroyonhitobstacle : MonoBehaviour
{
    bool gamehasended = false;
    
    // Start is called before the first frame update
   void OnCollisionEnter2D(Collision2D collision)
    {   
         if (collision.gameObject.tag == "player")
        {
            
            Debug.Log("gameoveradd");
             //GameObject.Find("gamecontroller").GetComponent<gamecontroller>().EndGame()
             if (gamehasended == false)
                {
                gamehasended = true;
                
                Invoke("Restart",2f);
                Restart();
                }

            void Restart()
            {
            //gameObject.GetComponent<follow>().speed = 10; 
             
            SceneManager.LoadScene("gameoveradd");            

            }


             //Instantiate(enemy, new Vector3(Random.Range(-10f, 10.0f),Random.Range(-20f, 20.0f),0),  Quaternion.identity);
        }   
        
    }
}
