using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class fueling : MonoBehaviour
{
    Vector3 lastPosition = Vector3.zero;
    public float dist;
    public float fuel;
    public float fuelvalue;
    bool gamehasended = false;
    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Vector2.Distance(lastPosition, transform.position));
        dist = (Vector2.Distance(lastPosition, transform.position));
        fuel = fuel - dist;
        lastPosition = transform.position;
        //Debug.Log(fuel);
        if(fuel <= 0)
        {
           
             //GameObject.Find("gamecontroller").GetComponent<gamecontroller>().EndGame()
             if (gamehasended == false)
                {
                gamehasended = true;
                
                
                Restart();
                }

            void Restart()
            {
                PlayerPrefs.SetInt("health",0);
            FindObjectOfType<AudioManager>().Play("gameover"); 
            SceneManager.LoadScene("gameoveradd");            
            }
              //Instantiate(enemy, new Vector3(Random.Range(-10f, 10.0f),Random.Range(-20f, 20.0f),0),  Quaternion.identity);
        }   
   
    }   

    // Start is called before the first frame update
   void OnCollisionEnter2D(Collision2D collision)
    {   
         if (collision.gameObject.tag == "fuel")
        {
                fuel = fuel + fuelvalue; //Debug.Log("ApplyDamage");
             //Destroy(gameObject);
             //Instantiate(gameObject, new Vector3(Random.Range(-12f, 12.0f),Random.Range(-20f, 20.0f),0),  Quaternion.identity);
            
        }  
      
    }

  

}
