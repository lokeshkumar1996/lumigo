using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randommove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
 private float nextActionTime = 0.0f;
 public float period = .2f;
 
 void Update () {
     if (Time.time > nextActionTime ) {
        nextActionTime += period;
         transform.position = Vector2.MoveTowards(transform.position,new Vector2(Random.Range(-10f, 10f),Random.Range(-10f, 10f)),Random.Range(10, 30)* Time.deltaTime);
         // execute block of code here
     }
 }
    // Update is called once per frame
    
     
    
}
