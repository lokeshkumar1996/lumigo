using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followwitdistswitch : MonoBehaviour
{
    public int followdistance;
    public int followspeed;
    Transform target;
    public Transform[] enemys;
    float timebtwmove;
    public float movefrequency;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void FixedUpdate()
    {
        if(timebtwmove <= 0)
        {

            target = enemys[Random.Range(0,enemys.Length -1)];
            timebtwmove = movefrequency;
        }
        else {
            timebtwmove -= Time.deltaTime;
        } 


      
        
    
      if(Vector2.Distance(transform.position, target.position) > followdistance)
      transform.position = Vector2.MoveTowards(transform.position,target.position,followspeed* Time.deltaTime);
    
    }

}
