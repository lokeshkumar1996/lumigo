using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resumepannel : MonoBehaviour
{
    // Start is called before the first frame update
    public void play()
    {
       //SceneManager.LoadScene("test4");
        GameObject.Find("resumepanel").SetActive(false);
        
            
        Time.timeScale = 1f; 
        GameObject.Find("player").GetComponent<playermove>().enabled =true;

       
    }


   
    //public void completelevel()
    //{
    //    levelcomplete.SetActive(true);
    //}

  public void mainmenu()
        {

          Debug.Log("start");
       //  Destroy(GameObject.Find("Purchaser"));
         //Destroy(GameObject.Find("googladmanager"));
         if((GameObject.Find("descriptiontrans") != null))
         {
           Destroy(GameObject.Find("descriptiontrans"));
         }
         if((GameObject.Find("scenetransfer") != null))
         {
           Destroy(GameObject.Find("scenetransfer"));
         }
         SceneManager.LoadScene("menu1");
        

        }

        



}
