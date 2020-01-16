using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followpropdist : MonoBehaviour
{

    //public float speed;
    public float dist;

    
    

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
          
      Debug.Log(Vector2.Distance(transform.position, target.position));
    dist  = Vector2.Distance(transform.position, target.position);
       //GameObject.Find("bubble").GetComponent<AudioSource>().Play();
     //speed = Random.Range(speedintensity, speedintensity+10); 
    //if(Vector.Distance(transform.position, target.position)>3)
      transform.position = Vector2.MoveTowards(transform.position,target.position, (dist/2) * Time.deltaTime );
    }
}
