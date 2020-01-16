using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkspeed : MonoBehaviour
{
    public float speed;
    
    Vector3  oldPosition; 
    // Start is called before the first frame update
    void Start()
    {
        oldPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         speed = Vector3.Distance (oldPosition, transform.position);
         // speedPerSec = Vector3.Distance (oldPosition, transform.position) / Time.deltaTime;
        // speed2 = (((transform.position - oldPosition).magnitude) / Time.deltaTime) ;
          oldPosition = transform.position;
    }
}
