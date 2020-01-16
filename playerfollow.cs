using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
       
      Vector2 desiredPosition;

    void Start() 
    {
       player = transform.parent.gameObject;
        
    }
    void FixedUpdate()  {         

    
    desiredPosition.x = player.transform.position.x;
     desiredPosition.y = player.transform.position.y;
      
    //target.position =  transform.parent.gameObject.transform.position.x;
    transform.position = desiredPosition;
    
       //Debug.Log( "Player's Parent: " + player.transform.parent.name );

    }



}
