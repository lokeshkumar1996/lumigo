using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vanishcounter : MonoBehaviour
{
    public Text  vanishcount;
    public int vanish = 0;
    public int vanishaccepted = 5;
    bool gamehasended = false;
    public bool vanishreset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       //vanishcount.text = GameObject.Find("gamecontroller").GetComponent<gamecontroller2>().vanishcount.ToString("0");
       vanishcount.text = vanish.ToString("0");

        if(vanishreset == true)
        {
            if (vanish >= 1)
             { 
             GameObject.Find("player").GetComponent<destroyonhitplayer>().pointscount = 0;
             vanish = 0;
             }
        }



       if (vanish > vanishaccepted)
        {                   
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
            FindObjectOfType<AudioManager>().Play("gameover"); 
            SceneManager.LoadScene("gameoveradd");            
            }
            //Instantiate(enemy, new Vector3(Random.Range(-10f, 10.0f),Random.Range(-20f, 20.0f),0),  Quaternion.identity);
        }    


    }
}
