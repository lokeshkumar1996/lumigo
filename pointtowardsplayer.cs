using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointtowardsplayer : MonoBehaviour
{

    public float speed;
    public GameObject[] player;
    public int followdistance;
    
    

    //speed = Random.Range(speedintensity, speedintensity+10);
    private Transform target;
    // Start is called before the first frame update
     public void Start()
    {    //target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();

      // player = GameObject.FindGameObjectsWithTag("player");
             
    }

    // Update is called once per frame
    void FixedUpdate()
    {

          player = GameObject.FindGameObjectsWithTag("player");
     

          if( player.Length == 2)
          {         
             if(Vector2.Distance(transform.position, player[1].GetComponent<Transform>().position) < Vector2.Distance(transform.position, player[0].GetComponent<Transform>().position) )
              target = player[1].GetComponent<Transform>();
             
            if(Vector2.Distance(transform.position, player[1].GetComponent<Transform>().position) > Vector2.Distance(transform.position, player[0].GetComponent<Transform>().position) )
             target = player[0].GetComponent<Transform>();          

          }else  target = player[0].GetComponent<Transform>();

           
     //speed = Random.Range(speedintensity, speedintensity+10); 
    //if(Vector.Distance(transform.position, target.position)>3)
        if(Vector2.Distance(transform.position, target.position) < followdistance)
            transform.position = Vector2.MoveTowards(transform.position,target.position, speed * Time.deltaTime);

         
    }



}


