using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkunlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("ReferalClaimed", 1);  
         if (AudioManager.instance.ReferalClaimed == 0)
         {
             this.transform.GetChild(1).gameObject.SetActive(true);
             this.transform.GetChild(0).gameObject.SetActive(false);
         }
         else
         {
             this.transform.GetChild(0).gameObject.SetActive(true);
             this.transform.GetChild(1).gameObject.SetActive(false);
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
