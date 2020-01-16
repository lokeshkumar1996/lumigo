using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelnameupdate : MonoBehaviour
{
    // Start is called before the first frame update
    public Text levelno;


    void Start()
    {   
        string s =  gameObject.transform.parent.name;
        int start = s.IndexOf("(") + 1;
        int end = s.IndexOf(")", start);
        string result = s.Substring(start, end - start);
        
      levelno.text = result;
      //ToString("0");

    }
}

