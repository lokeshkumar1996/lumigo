using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class networkcheck : MonoBehaviour
{
    //public static networkcheck instance;
    public bool networkon;
    
    // Start is called before the first frame update
    void Start()
    {

        if(Application.internetReachability != NetworkReachability.NotReachable)
        {
           
            networkon = true;

        }else
        {
            
             networkon = false;
             

        }
              
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Application.internetReachability != NetworkReachability.NotReachable)
        {
           
            networkon = true;

        }else
        {
            
             networkon = false;
             

        }
    }
}
