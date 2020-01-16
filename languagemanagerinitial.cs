using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class languagemanagerinitial : MonoBehaviour
{
   // public Text lable ;
    public string language;
    LocalizationManager localmanager;
   // public Dropdown drop;
   // int dropvalue;

     // PlayerPrefs.SetString("language", m_PlayerName);
      //level = PlayerPrefs.GetString("language");
    // Start is called before the first frame update
    void Start()
    {   
        //drop.value = 0;   
        //dropvalue = drop.value; 
       // language = lable.text;
       
        PlayerPrefs.SetString("language", "english"); 
        localmanager = GameObject.Find("LocalizationManager").GetComponent<LocalizationManager>();
        localmanager.LoadLocalizedText("english");

        //checklangloadinit() ;
       // PlayerPrefs.SetInt("languagevalue", dropvalue);
        //PlayerPrefs.SetString("language", language);       
       
    }

    // Update is called once per frame
   /*  public void onchange()
    {   
        //GameObject.Find("start").GetComponent<Button>().interactable = false;
        
        language = lable.text;
        dropvalue = drop.value; 
        PlayerPrefs.SetInt("languagevalue", dropvalue);
        PlayerPrefs.SetString("language", language);
       // LocalizationManager.instance.isReady = false;
        
       GameObject.Find("LocalizationManager").GetComponent<LocalizationManager>().LoadLocalizedText(language);
    
       // GameObject.Find("start").GetComponent<Button>().interactable = true;
       
    
         
    }*/

    
    
}

