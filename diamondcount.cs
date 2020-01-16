using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diamondcount : MonoBehaviour
{
    int curdiamonds;
    public Text diamonddisplaycount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
   
   

        curdiamonds = PlayerPrefs.GetInt("diamonds");
        Debug.Log("curdia= "+PlayerPrefs.GetInt("diamonds"));
        diamonddisplaycount.text = curdiamonds.ToString("0");
        
    
    }
}
