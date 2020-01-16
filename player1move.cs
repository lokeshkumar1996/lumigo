using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1move : MonoBehaviour
{
     float height ;
    float width ;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector2 topRightCorner = new Vector2(1, 1);
        Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
        height = edgeVector.y ;
        width = edgeVector.x ;


       if (Input.touchCount > 0)
       {
            Touch touch1 = Input.GetTouch(0);
            Vector3 touchPosition1 = Camera.main.ScreenToWorldPoint(touch1.position);
            touchPosition1.z = 0f;
            
            
         
         if (touchPosition1.x < (width-1) && touchPosition1.x > -(width-1) && touchPosition1.y < (height-2) && touchPosition1.y > -(height-2)  ) 
         {
             transform.position = touchPosition1;
         }
        }

        
    }
}
