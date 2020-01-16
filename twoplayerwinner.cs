using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class twoplayerwinner : MonoBehaviour
{
    int winner;
    public GameObject Player1;
    public GameObject Player2;
    // Start is called before the first frame update
    void Start()
    {
        winner = GameObject.Find("gamecontroller").GetComponent<gamecontroller2player>().winner;
        Debug.Log("winner="+winner);  
        if(winner ==1)
        {
            Player1.SetActive(true);
        }
        if(winner ==2)
        {
            Player2.SetActive(true);
        }

        
        Destroy( GameObject.Find("gamecontroller"));

        Time.timeScale = 1f;   

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mainmenu()
        {

       
         if (GameObject.Find("twoplayertransfer") != null)
            {
                Destroy(GameObject.Find("twoplayertransfer")); 
            }
         SceneManager.LoadScene("menu1");
        

        }
        public void restart()
        {

         
        Scene scene = SceneManager.GetActiveScene();
         SceneManager.LoadScene(scene.name);
        

        }
}
