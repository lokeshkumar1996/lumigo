using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pannel2 : MonoBehaviour
{ 
    public int level;
    int levelcheck;    
    int pannelint;
    string pannel;
    string pannelname;

    void Start()
    { 
      //PlayerPrefs.SetInt("leveldone",80);
      pannelname = gameObject.name;
      pannel = string.Concat(pannelname[5], pannelname[6]);
      pannelint = int.Parse(pannel);
       
      
      levelcheck = PlayerPrefs.GetInt("leveldone");

      if(levelcheck / 8 >= pannelint)
      {
        GameObject[] levelbutton = GameObject.FindGameObjectsWithTag ("level");
         for(int i=0; i< 8; i++)
        {
        string star;
        star =(((pannelint - 1)  * 8) + i+1).ToString("0");
        
       // Debug.Log(PlayerPrefs.GetInt(star));
        
        levelbutton[i].GetComponent<Button>().interactable = true;
        //Debug.Log(levelbutton[i].name);
          if(PlayerPrefs.GetInt(star) == 3)
          {
          levelbutton[i].transform.GetChild(1).gameObject.SetActive(true);
          levelbutton[i].transform.GetChild(2).gameObject.SetActive(true);
          levelbutton[i].transform.GetChild(3).gameObject.SetActive(true);
          }
          if(PlayerPrefs.GetInt(star) == 2)
          {
          levelbutton[i].transform.GetChild(1).gameObject.SetActive(true);
          levelbutton[i].transform.GetChild(2).gameObject.SetActive(true);
          }
          if(PlayerPrefs.GetInt(star) == 1)
          { 
          levelbutton[i].transform.GetChild(1).gameObject.SetActive(true);
          }
          }
      }
      else if( levelcheck > 8 * (pannelint -1) && levelcheck < 8 * pannelint )
      {

      level = levelcheck % 8;

      if (level == 0)
      level = 8;
       //GameObject.Find("1 (9)").GetComponent<Button>().interactable = true;

      //PlayerPrefs.SetInt("1",3);
     //PlayerPrefs.SetInt("2",2);
      //PlayerPrefs.SetInt("3",3);
      //Debug.Log("1 " + PlayerPrefs.GetInt("1"));
      //Debug.Log("2 " + PlayerPrefs.GetInt("2"));
      //sDebug.Log("3 " + PlayerPrefs.GetInt("3"));


      //Debug.Log(level );  
      GameObject[] levelbutton = GameObject.FindGameObjectsWithTag ("level");
      //levelbutton[0].GetComponent<Button>().interactable = true;
 
       for(int i=0; i< level; i++)
      {
        string star;
        star =(((pannelint - 1)  * 8) + i+1).ToString("0");
       // Debug.Log(PlayerPrefs.GetInt(star));
        
        levelbutton[i].GetComponent<Button>().interactable = true;
        //Debug.Log(levelbutton[i].name);
          if(PlayerPrefs.GetInt(star) == 3)
          {
          levelbutton[i].transform.GetChild(1).gameObject.SetActive(true);
          levelbutton[i].transform.GetChild(2).gameObject.SetActive(true);
          levelbutton[i].transform.GetChild(3).gameObject.SetActive(true);
          }
          if(PlayerPrefs.GetInt(star) == 2)
          {
          levelbutton[i].transform.GetChild(1).gameObject.SetActive(true);
          levelbutton[i].transform.GetChild(2).gameObject.SetActive(true);
          }
          if(PlayerPrefs.GetInt(star) == 1)
          { 
          levelbutton[i].transform.GetChild(1).gameObject.SetActive(true);
          }
          
      }
     }
    }

    
}
