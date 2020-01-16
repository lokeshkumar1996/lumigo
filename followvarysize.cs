using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followvarysize : MonoBehaviour
{

    public float speed;
    public float size;
    public int growthinverse;
    

    //speed = Random.Range(speedintensity, speedintensity+10);
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       size = size+ (Time.deltaTime/growthinverse);
      
     //speed = Random.Range(speedintensity, speedintensity+10); 
     transform.localScale = new Vector3(size, size, 0);
    //if(Vector.Distance(transform.position, target.position)>3)
      transform.position = Vector2.MoveTowards(transform.position,target.position,Random.Range(speed, speed*2)* Time.deltaTime);
    }

   
     
    
}
