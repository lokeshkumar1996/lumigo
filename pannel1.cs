using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pannel1 : MonoBehaviour
{
    public int level;
    int levelcheck;    
    int pannelint;
    string pannel;
    string pannelname;
    int enableuntill;

    void Start()
    { 
      PlayerPrefs.SetInt("leveldone",8);
      pannelname = gameObject.name;
      pannel = string.Concat(pannelname[5], pannelname[6]);
      pannelint = int.Parse(pannel);
      levelcheck = PlayerPrefs.GetInt("leveldone");

      enableuntill = levelcheck % 8;

      if((levelcheck/8) > pannelint)
      {
          for( int i=0; i<8; i++)
        {
        this.transform.GetChild(i).gameObject.GetComponent<Button>().interactable = true;
        string star;
        star = (((pannelint - 1)  * 8) + i+1).ToString("0");
        Debug.Log("star ="+ star);
        if(PlayerPrefs.GetInt(star) == 3)
          {
          this.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.SetActive(true);
          this.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.SetActive(true);
          this.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.SetActive(true);
          }
          if(PlayerPrefs.GetInt(star) == 2)
          {
          this.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.SetActive(true);
          this.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.SetActive(true);
          }
          if(PlayerPrefs.GetInt(star) == 1)
          { 
          this.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.SetActive(true);
          }  
        }
      }
      else
      {
      if( enableuntill == 0)
      {
        for( int i=0; i<8; i++)
        {
        this.transform.GetChild(i).gameObject.GetComponent<Button>().interactable = true;
        string star;
        star = (((pannelint - 1)  * 8) + i+1).ToString("0");
        Debug.Log("star ="+ star);
        if(PlayerPrefs.GetInt(star) == 3)
          {
          this.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.SetActive(true);
          this.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.SetActive(true);
          this.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.SetActive(true);
          }
          if(PlayerPrefs.GetInt(star) == 2)
          {
          this.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.SetActive(true);
          this.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.SetActive(true);
          }
          if(PlayerPrefs.GetInt(star) == 1)
          { 
          this.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.SetActive(true);
          }  
        }
      }else
      {
         for( int i=1; i<=enableuntill; i++)
        {
        this.transform.GetChild(i-1).gameObject.GetComponent<Button>().interactable = true;
        string star;
        star = ((pannelint * 8) +i).ToString("0");
        if(PlayerPrefs.GetInt(star) == 3)
          {
          this.transform.GetChild(i-1).gameObject.transform.GetChild(1).gameObject.SetActive(true);
          this.transform.GetChild(i-1).gameObject.transform.GetChild(2).gameObject.SetActive(true);
          this.transform.GetChild(i-1).gameObject.transform.GetChild(3).gameObject.SetActive(true);
          }
          if(PlayerPrefs.GetInt(star) == 2)
          {
          this.transform.GetChild(i-1).gameObject.transform.GetChild(1).gameObject.SetActive(true);
          this.transform.GetChild(i-1).gameObject.transform.GetChild(2).gameObject.SetActive(true);
          }
          if(PlayerPrefs.GetInt(star) == 1)
          { 
          this.transform.GetChild(i-1).gameObject.transform.GetChild(1).gameObject.SetActive(true);
          }
        } 
      }
      }




     
    }


     

    // Update is called once per frame
    void Update()
    {
        
    }
}
