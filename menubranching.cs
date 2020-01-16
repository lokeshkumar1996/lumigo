using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menubranching : MonoBehaviour
{
    string language;
    public LocalizationManager localmanager;
    public LevelDiamonddata l;
    public ReferalPurchasedata p;

    // Start is called before the first frame update
    private IEnumerator Start()
    {
        //yield return new WaitForSeconds(.5f);

        if (PlayerPrefs.HasKey("initialmenu") == false)
        {
        //PlayerPrefs.SetInt("initialmenu",1); 
        SceneManager.LoadScene("initialmenu");        
        }
        else 
        {
            
            if ( PlayerPrefs.HasKey("logomenu") == false )
            {
                Debug.Log("logomenu haskey");
                Debug.Log("logomenu haskey"+ PlayerPrefs.GetInt("leveldone"));

                l.leveldone = PlayerPrefs.GetInt("leveldone");
                l.diamonds = PlayerPrefs.GetInt("diamonds");                
                p.noads = PlayerPrefs.GetInt("noads");
                p.ReferalClaimed = PlayerPrefs.GetInt("ReferalClaimed");
                p.otherreferalclaimed = PlayerPrefs.GetInt("otherreferalclaimed");
                AudioManager.instance.noads = p.noads;
                AudioManager.instance.ReferalClaimed = p.ReferalClaimed;
                AudioManager.instance.otherreferalclaimed = p.otherreferalclaimed;
                AudioManager.instance.leveldone = l.leveldone;
                AudioManager.instance.diamonds = l.diamonds;
                l.savedata();
                p.savedata();

                //l.loaddata();
               // p.loaddata();
                 PlayerPrefs.SetInt("logomenu",1);
            }
            else
            {
                Debug.Log("else");
                l.loaddata();
                AudioManager.instance.leveldone = l.leveldone;
                AudioManager.instance.diamonds = l.diamonds;
                p.loaddata();
                AudioManager.instance.noads = p.noads;
                AudioManager.instance.ReferalClaimed = p.ReferalClaimed;
                AudioManager.instance.otherreferalclaimed = p.otherreferalclaimed;

            }
        
        /* if(PlayerPrefs.GetInt("health") == 0)    
        {
            int curlevel = PlayerPrefs.GetInt("leveldone");
            if (curlevel == 1)
            {
              PlayerPrefs.SetInt("leveldone",curlevel);
              PlayerPrefs.SetInt("health",3);          
            }
            else{
                PlayerPrefs.SetInt("leveldone",curlevel-1);
                PlayerPrefs.SetInt("health",1);
            }
            
        }*/
        language = PlayerPrefs.GetString("language");    
        localmanager.LoadLocalizedText(language);
        yield return new WaitForSeconds (1f);
        //SceneManager.LoadScene("menu1");
        }
        
        
    }

    // Update is called once per frame
  
}
