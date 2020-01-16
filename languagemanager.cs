using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class languagemanager : MonoBehaviour
{
    public Text lable ;
    public string language;
    //public string currlang;
   //public LocalizationManager localmanager;
    public Dropdown drop;
    int dropvalue;

     // PlayerPrefs.SetString("language", m_PlayerName);
      //level = PlayerPrefs.GetString("language");
    // Start is called before the first frame update
    void Start()
    {
       //lable.text = "test";
       drop.value = PlayerPrefs.GetInt("languagevalue");        
       // Debug.Log(dropvalue);
      
    }

    // Update is called once per frame
    public void onchange()
    {      

        language = lable.text;
        dropvalue = drop.value;      
      
        PlayerPrefs.SetInt("languagevalue", dropvalue);
        PlayerPrefs.SetString("language", language);
        
        GameObject.Find("LocalizationManager").GetComponent<LocalizationManager>().LoadLocalizedText(language);
        //localmanager.LoadLocalizedText(language);


    }

    
}
