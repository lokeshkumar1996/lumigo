using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class onclickinlevelselect : MonoBehaviour
{
    
   // Button button;
   // public bool unlocked;
    int levelno;
    float elapsed = 0f;
    bool buttonclickedtrue = false;
    public string loadscene;
    public bool loadsceneispresent;
    public float dealytime = .4f;
    // Start is called before the first frame update

    void Update()
    {
         
        if(buttonclickedtrue == true)
        { Time.timeScale = 1f; 
          Debug.Log("buttontrue");
          elapsed += Time.deltaTime;
          Debug.Log("elapsed="+elapsed);

          if(elapsed > dealytime)
          {
            Debug.Log("teimeelasped");
            Debug.Log(buttonclickedtrue);
          buttonclickedtrue = false;
          Debug.Log(buttonclickedtrue);
          if(loadsceneispresent)
          SceneManager.LoadScene((loadscene));
          else
          {
              SceneManager.LoadScene((levelno*2));
          }

          }
        }
        
    }
     public void OnClicked(Button button)
        {
         
        //Debug.Log(button.name);      
        string s =  button.name;
        int start = s.IndexOf("(") + 1;
        int end = s.IndexOf(")", start);
        string result = s.Substring(start, end - start);
        levelno = int.Parse(result);
        Debug.Log(levelno);
        buttonclickedtrue = true;
        elapsed = 0f;
        GameObject.Find("audioclick").GetComponent<AudioSource>().Play(); 
        //Invoke("delay",1f);
       
        //SceneManager.LoadScene((levelno*2));
        }
       

        
}
