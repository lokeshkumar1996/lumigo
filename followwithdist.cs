using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followwithdist : MonoBehaviour
{
    public int followdistance;
    public int followspeed;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void FixedUpdate()
    {
      
    
    
      if(Vector2.Distance(transform.position, target.position) > followdistance)
      transform.position = Vector2.MoveTowards(transform.position,target.position,followspeed* Time.deltaTime);
    
    }

}
