using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelscreen : MonoBehaviour
{   
    int currentlevel;
    public GameObject[] pannels;
    public GameObject[] images;
    public int referalcount = 0;
    public bool unlocked;
    int levelno;
    

    void Start()
    {

      

      //currentlevel = (PlayerPrefs.GetInt("leveldone") + 1);
      currentlevel = AudioManager.instance.leveldone + 1;
      Debug.Log("currentlevel =" +currentlevel);

      if(currentlevel > 80)
      {
        currentlevel = 80;
      }

      for(int i=0; i<=10; i++)
      {
      if(currentlevel > 8*i && currentlevel <= 8*(i+1))
      {
      pannels[i].SetActive(true);
      images[i].SetActive(true);
      }

      }
      
      
      
    }
    

   
    
   public void mainmenu()
        {
        // Destroy(GameObject.Find("Purchaser"));
        // Destroy(GameObject.Find("googladmanager"));
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
