using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rateustimer : MonoBehaviour
{
    
    // Start is called before the first frame update
    public static rateustimer instance;
    public float timer;
    GameObject rateuspannel;
    GameObject parentObject;
    bool networkon;
    public int reminderinmin;
    
        
    void Awake()
    {

        if(instance == null)
            instance =this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

      //rateuspannel = GameObject.Find("rating");
      //rateuspannel.SetActive(false);
     
    if(PlayerPrefs.GetInt("rating") == 1)
    {
        Destroy(gameObject);
    }
                   
       SceneManager.sceneLoaded += OnSceneLoaded; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            
            if((SceneManager.GetActiveScene().name == "menu1"))
            {
              parentObject =  GameObject.Find("mainmenu");
              rateuspannel = parentObject.transform.GetChild(9).gameObject;    
                if(Application.internetReachability != NetworkReachability.NotReachable)
                {
          
                if( timer >= reminderinmin *60  )
                {                   
                
                rateuspannel.SetActive(true);
                
                }

                }
              

              
            }
            
        }





}
