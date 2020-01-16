using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    //public GameObject movement;
    //public GameObject diff;  

    //int collisisoncount;
    
    
    void OnCollisionEnter2D(Collision2D collision)
    {   
         if (collision.gameObject.tag == "enemy")
        {
            //Debug.Log("ApplyDamage");
            Destroy(this);
            
        }   
        
    }


}
