using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawlinebetweenenemy : MonoBehaviour
{
    
    public GameObject enemy1;
    //public GameObject enemy2;
    public LineRenderer lineRenderer;
    //public EdgeCollider2D MyEdgeCollider2D;
    Vector2[] colliderpoints;
    public float speed;
    public GameObject[] player;
    private Transform target;

    
   
    
    // Start is called before the first frame update
    void Start()
    {
        //line= gameObject.GetComponent<LineRenderer>();
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        
         
      //  MyEdgeCollider2D= gameObject.GetComponent<EdgeCollider2D> ();
    
      //  line.SetWidth(.2f , .2f); 
    }

    // Update is called once per frame
   
    void FixedUpdate()
    {
        player = GameObject.FindGameObjectsWithTag("player");
        lineRenderer.SetPosition(0, enemy1.transform.position);
          
         
        
      // GameObject.Find("bubble").GetComponent<AudioSource>().Play();

          if( player.Length == 2)
          {         
             if(Vector2.Distance(transform.position, player[1].GetComponent<Transform>().position) < Vector2.Distance(transform.position, player[0].GetComponent<Transform>().position) )
             { target = player[1].GetComponent<Transform>();
                lineRenderer.SetPosition(1, target.position);
             }

             
            if(Vector2.Distance(transform.position, player[1].GetComponent<Transform>().position) > Vector2.Distance(transform.position, player[0].GetComponent<Transform>().position) )
             {target = player[0].GetComponent<Transform>(); 
                 lineRenderer.SetPosition(1, target.position);
             }         

          }else  {target = player[0].GetComponent<Transform>();   lineRenderer.SetPosition(1, target.position);}

           
     //speed = Random.Range(speedintensity, speedintensity+10); 
    //if(Vector.Distance(transform.position, target.position)>3)
        transform.position = Vector2.MoveTowards(transform.position,target.position,Random.Range(speed, speed*2)* Time.deltaTime);
        
    }

   

  
   
   
     
   
}
