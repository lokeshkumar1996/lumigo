using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow3down : MonoBehaviour
{
    // Start is called before the first frame update
   public float speed;
   public float enemypointdist;
    

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
     //speed = Random.Range(speedintensity, speedintensity+10); 
    if(Vector2.Distance(gameObject.transform.parent.position, target.position) < enemypointdist)
    {
      if ( target.position.y < gameObject.transform.parent.position.y)
      transform.position = Vector2.MoveTowards(transform.position,target.position, speed* Time.deltaTime);
    }
    }
}
