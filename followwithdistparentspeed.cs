using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followwithdistparentspeed : MonoBehaviour
{
    public int followdistance;
    float followspeed;
    public GameObject followobject;
    
   
   
   


    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = followobject.transform;
    }
    
    void FixedUpdate()
    {

    followspeed = followobject.GetComponent<followrandomspeed>().speed;
    if(Vector2.Distance(transform.position, target.position) > followdistance)
      transform.position = Vector2.MoveTowards(transform.position,target.position,followspeed* Time.deltaTime);

    }

}
