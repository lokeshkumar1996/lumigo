using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidebuyfullversion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       if(AudioManager.instance.noads ==1) 
       {
           gameObject.SetActive(false);
       }
       else gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
