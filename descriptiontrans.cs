using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class descriptiontrans : MonoBehaviour
{
    public string pass;
    public string levellimit;
    public Text leveldec;
    public Text levellim;
    public Text levelno;
    string decname;
    string decno;
    string namekey;
    string limitkey;
    


    

    
    
    void Awake()
    {
            

        decno = string.Concat(SceneManager.GetActiveScene().name[3], SceneManager.GetActiveScene().name[4]);
        namekey = string.Concat("leveldescription", decno);
        limitkey = string.Concat("levelimit", decno);
        levelno.text = decno;
         

        GameObject.Find("leveldescription").GetComponent<LocalizedText>().key = namekey;
        GameObject.Find("levelimit").GetComponent<LocalizedText>().key = limitkey;
      
            pass = LocalizationManager.instance.GetLocalizedValue (namekey);
            levellimit = LocalizationManager.instance.GetLocalizedValue (limitkey);          

        
    }

   

        
    
   

}
