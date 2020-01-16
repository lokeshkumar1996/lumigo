using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ripplefollow : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject target; 
    //GameObject obj = this.transform.parent;
    

    void FixedUpdate()
    {   
             

     transform.position = target.transform.position;
      // transform.position = Parent.transform.position;
       //Debug.Log( "Player's Parent: " + player.transform.parent.name );

    }



}
