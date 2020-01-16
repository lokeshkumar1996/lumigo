using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class referalvalidation : MonoBehaviour {

    //private string myKey;
    //public Text MyReferalkey;
    //public Text count1;
    //public Text count2;
    public string ReferralKeyInput;
    //public Text QueryResultText; 

    public int count;
    public ReferalPurchasedata p;
    //public GameObject sharbut;
    //public GameObject pannel;
    //public GameObject shareorbuypannel;
   // public GameObject activatepannel;


    ReferAFriend.BackendConfig config;


    public void Start(){        
        
        if (AudioManager.instance.ReferalClaimed == 0)
         {
        string initURL =  "https://bq070kqvh9.execute-api.us-east-1.amazonaws.com/prod/referralsInit";
        string claimURL = "https://bq070kqvh9.execute-api.us-east-1.amazonaws.com/prod/referralsClaim";
        string countURL = "https://bq070kqvh9.execute-api.us-east-1.amazonaws.com/prod/referralsCount";
        config = new ReferAFriend.BackendConfig(initURL, claimURL, countURL);
        ReferAFriend.Instance.makeconfig(config);

        ReferralKeyInput = PlayerPrefs.GetString("ReferalCode");
         Debug.Log(PlayerPrefs.GetString("ReferalCode"));
          ReferAFriend.Instance.CheckReferralCodeUsageCount(
            ReferralKeyInput,
            (responseValue) => { count = responseValue; },
            (responseCode) => { Debug.LogError("There was an error calling ReferAFriend GetCount(): " + responseCode); });
        Debug.Log(count);         
        GameObject.Find("levelmenu").GetComponent<levelscreen>().referalcount = count;
        
        Invoke("ExecuteAfterTime", 2f);
        }
        else
        {
        //pannel.SetActive(true);
        GameObject.Find("levelmenu").GetComponent<levelscreen>().unlocked = true;
       // shareorbuypannel.SetActive(false);
        }
    }
     


    void ExecuteAfterTime()
    {      
        GameObject.Find("levelmenu").GetComponent<levelscreen>().referalcount = count;
     if (count >= 2)
        {
        Debug.Log("ReferalCode claimed" + count);
        //pannel.SetActive(true);
        GameObject.Find("levelmenu").GetComponent<levelscreen>().unlocked = true;
        //shareorbuypannel.SetActive(false); 
        //activatepannel.SetActive(true);       

         //PlayerPrefs.SetInt("ReferalClaimed", 1);   
         AudioManager.instance.ReferalClaimed = 1;

        p.noads = AudioManager.instance.noads;
        p.ReferalClaimed = AudioManager.instance.ReferalClaimed;
        p.otherreferalclaimed = AudioManager.instance.otherreferalclaimed;
        p.savedata();

        }
    }

}

    
 
