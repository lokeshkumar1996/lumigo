using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    
    public float endtime;    
    public float elapsed ;  
    public int scorelimit;
    public float timerend = 50;
    public bool endmentioned;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
       endmentioned = false;
       player = GameObject.Find("player");
  
    }

    // Update is called once per frame
    void Update()
    {

         
   
         //Debug.Log("time"); 
        elapsed += Time.deltaTime;
      
        
        /*if ((player.GetComponent<destroyonhitplayer>().pointscount) >= scorelimit && endmentioned == false )
        {   
            endtime = elapsed;
            //endmentioned = true;
            
        }

         if (elapsed >= timerend && endmentioned == false)
        {   
            endtime= elapsed;
            
            
        }*/

    }
}
