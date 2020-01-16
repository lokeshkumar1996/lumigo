using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushingfriend : MonoBehaviour
{
   
   public float speed;
   public float playerpointdist;
   float height ;
   float width ; 
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
         target = GameObject.Find("player").GetComponent<Transform>();
          Vector2 topRightCorner = new Vector2(1, 1);
      Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
      height = edgeVector.y - 4 ;
      width = edgeVector.x - 2;

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     


     //speed = Random.Range(speedintensity, speedintensity+10); 
    //if(Vector2.Distance(transform.position, target.position) < playerpointdist)
    //{
    //  transform.position = Vector2.MoveTowards(transform.position,target.position, - speed * Time.deltaTime);
    //}
    
    if (transform.position.x > (width+5) || transform.position.x < -(width+5) || transform.position.y > (height+5) || transform.position.y < -(height+5) ) 
    {
      GameObject.Find("gamecontroller").GetComponent<gamecontroller7>().gameend();
    }
    }
}
