using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handlefollow : MonoBehaviour
{
     public  Transform target;
     public float speed ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        speed = Vector2.Distance(transform.position, target.position) * 10 ;

        if (Input.touchCount > 0 )   
        {
         transform.position = Vector2.MoveTowards(transform.position,target.position, speed* Time.deltaTime);
        }
        else
        {
         transform.position = target.position;
       }
        
     }
}
