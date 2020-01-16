using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilesticktoplayerpos1 : MonoBehaviour
{
    public float speed;
     //Transform hit;
     Vector2 targetdir;
     public GameObject[] player;
     private Transform target;
     public Vector2 direction;


    // Start is called before the first frame update
    void Start()
    {
      // hit = GameObject.Find("player").transform;
       //targetdir = new Vector2(hit.position.x, hit.position.y);

       
        player = GameObject.FindGameObjectsWithTag("player");
      // GameObject.Find("bubble").GetComponent<AudioSource>().Play();

          if( player.Length == 2)
          {         
             if(Vector2.Distance(transform.position, player[1].GetComponent<Transform>().position) < Vector2.Distance(transform.position, player[0].GetComponent<Transform>().position) )
              target = player[1].GetComponent<Transform>();
             
            if(Vector2.Distance(transform.position, player[1].GetComponent<Transform>().position) > Vector2.Distance(transform.position, player[0].GetComponent<Transform>().position) )
             target = player[0].GetComponent<Transform>();          

          }else  target = player[0].GetComponent<Transform>();

     targetdir = new Vector2(target.position.x, target.position.y);


    
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position,targetdir,speed*Time.deltaTime); 

     
    }
}

