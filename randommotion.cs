using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randommotion : MonoBehaviour
{

  float height ;
  float width ;
     // Start is called before the first frame update
   public float speed;
   public Vector2 target;
   
    

    //speed = Random.Range(speedintensity, speedintensity+10);
    
    // Start is called before the first frame update
    void Start()
    {
        target =   new Vector2(Random.Range(-11f, 11.0f), Random.Range(-22f, 17.5f));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       Vector2 topRightCorner = new Vector2(1, 1);
      Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
      height = edgeVector.y ;
      width = edgeVector.x ;
       
      transform.position = Vector2.MoveTowards(transform.position,target, speed* Time.deltaTime);

      if(Vector2.Distance(transform.position, target) <= 2)
      {
          target =   new Vector2(Random.Range((width-1), -(width-1)), Random.Range(-(height-2), (height-4)));
      }
    
    }
    
}
