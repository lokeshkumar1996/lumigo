using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createreferalcode : MonoBehaviour
{
    // Start is called before the first frame update
    private string myKey;
   // public Text MyKeyInput;
   

    ReferAFriend.BackendConfig config;


    void Start(){
        string initURL =  "https://bq070kqvh9.execute-api.us-east-1.amazonaws.com/prod/referralsInit";
        string claimURL = "https://bq070kqvh9.execute-api.us-east-1.amazonaws.com/prod/referralsClaim";
        string countURL = "https://bq070kqvh9.execute-api.us-east-1.amazonaws.com/prod/referralsCount";
        config = new ReferAFriend.BackendConfig(initURL, claimURL, countURL);
        ReferAFriend.Instance.makeconfig(config);
        Init();
        //Debug.Log("referal="+PlayerPrefs.GetString("ReferalCode"));
    }

    public void Init(){
       //ReferAFriend.Instance.ResetMyReferalCode(); // this is for debug only - remove in production code not to generate multiple codes for one user
        ReferAFriend.Instance.Init(config, 
                                   (responseValue) => {myKey = responseValue; PlayerPrefs.SetString("ReferalCode",myKey);  },
                                   (responseCode) => { Debug.LogError("There was an error calling ReferAFriend Init(): " + responseCode);});
                                   // MyKeyInput.text = myKey;
    }
}
