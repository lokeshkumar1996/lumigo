using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2move : MonoBehaviour
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



       if(Input.touchCount > 1)
        {
         Touch touch2 = Input.GetTouch(1);
            Vector3 touchPosition2 = Camera.main.ScreenToWorldPoint(touch2.position);
            touchPosition2.z = 0f;
            

         if (touchPosition2.x < (width-1) && touchPosition2.x > -(width-1) && touchPosition2.y < (height-2) && touchPosition2.y > -(height-2)  ) 
         {
             transform.position = touchPosition2;
         }
        }
    }
}
