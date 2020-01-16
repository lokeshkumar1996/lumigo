using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspeed : MonoBehaviour
{

    public float speed;
    

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
       GameObject.Find("bubble").GetComponent<AudioSource>().Play();
     //speed = Random.Range(speedintensity, speedintensity+10); 
    //if(Vector.Distance(transform.position, target.position)>3)
      transform.position = Vector2.MoveTowards(transform.position,target.position,Random.Range(speed, speed*12)* Time.deltaTime);
    }
}
