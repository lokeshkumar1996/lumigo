using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextbutton : MonoBehaviour
{
    int pannelint;
    string pannel;
    string pannelname;

    void Start()
    { 
      //PlayerPrefs.SetInt("leveldone",1);
      pannelname = transform.parent.gameObject.name;
      pannel = string.Concat(pannelname[5], pannelname[6]);
      pannelint = int.Parse(pannel);
    }

    // Update is called once per frame
    
    // Update is called once per frame


    public void onclicknext(){
        GameObject[] panel = GameObject.FindGameObjectsWithTag ("panel");
      //string panneltoenable ;
      //string pannelintstring = (pannelint + 1).ToString("0");

      //panneltoenable = string.Concat("Panel0", pannelintstring);


      //string panneltodisable = transform.parent.gameObject.name;
     Debug.Log(panel[pannelint-1].name);
     // Debug.Log(panel[pannelint].name);
      //GameObject.Find(panneltoenable).SetActive(true);
     //GameObject.Find(panneltodisable).SetActive(false);
     panel[pannelint-1].SetActive(false);
     panel[pannelint].SetActive(true);




    }
}
