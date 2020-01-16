using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainmenu : MonoBehaviour
{ 
    //testingpurpose
    public Text inputlevelno;
    //public LocalizationManager localmanager;
     public GameObject networkcheckpanel;
     public GameObject closeplanel; 
     public GameObject menupanel;
     public GameObject storepanel;
     public GameObject optionpanel;   

     bool buttonclickedtrue = false;
     float elapsed = 0f;
     
     

     void Start()
     {
       // goclick = false;
       // StartCoroutine(LoadScenenextlevel());
     }


    void Update()
    {              
      if( GameObject.Find("networkcheck").GetComponent<networkcheck>().networkon)
        {
            networkcheckpanel.SetActive(false);
        }else{networkcheckpanel.SetActive(true); }

        
        if (Application.platform == RuntimePlatform.Android)
        {   
            if(Input.GetKeyDown(KeyCode.Escape))
            {

                if(menupanel.activeSelf)
                  {
                    PlayerPrefs.Save();
                    closeplanel.SetActive(true);
                  }else if(storepanel.activeSelf)
                  {
                      menupanel.SetActive(true);
                      storepanel.SetActive(false);

                  }else if(optionpanel.activeSelf)
                  {
                      menupanel.SetActive(true);
                      optionpanel.SetActive(false);
                  }
                   
            }
        }


        if(buttonclickedtrue == true)
        { Time.timeScale = 1f; 
          elapsed += Time.deltaTime;
          if(elapsed > .4f)
          {
          
          //int leveltoload =  PlayerPrefs.GetInt("leveldone");
          int leveltoload = AudioManager.instance.leveldone; 

          Debug.Log(leveltoload);

            if(leveltoload == 80)
            {
             SceneManager.LoadScene((leveltoload)*2);
             buttonclickedtrue = false;
            }else{
              SceneManager.LoadScene((leveltoload +1)*2);
             buttonclickedtrue = false;
            }
          
          }
        }

            
    }

       public void selectlevel()
        {
             // Debug.Log("level133");
            //Debug.Log("level1");
         //Destroy(GameObject.Find("player"));   
         //SceneManager.LoadScene("levelchose");
        // goclick = true;
          buttonclickedtrue = true;
        }

    

    // Start is called before the first frame update
   public void playgame()
        {
           //testingpurpouse
            string input = inputlevelno.text;
            int temp =  int.Parse(input);
            //Debug.Log("temp="+ temp);        
            //PlayerPrefs.SetInt("leveldone",temp);
             SceneManager.LoadScene(temp*2);
           
        }

    


    public void languagemenu()
        {
             // Debug.Log("level133");
           // if (GameObject.Find("LocalizationManager") != null)
          //  {
          //      Destroy(GameObject.Find("LocalizationManager")); 
          //  }
            //Debug.Log("level1");
         //Destroy(GameObject.Find("player"));   
         SceneManager.LoadScene("languagemenu");
        }

    public void quitgame()
    {
        Application.Quit();
    }


       public void catchem2p()
        {  
         SceneManager.LoadScene("catchem2p");
        }

        public void escape2p()
        {
         SceneManager.LoadScene("escape2p");
        }

        public void mixed2p()
        {
         SceneManager.LoadScene("mixed2p");
        }
     
}
