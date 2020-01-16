using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_quad3 : MonoBehaviour
{

    public float speed;
    public GameObject[] player;
    float height ;
    float width ;
    

    //speed = Random.Range(speedintensity, speedintensity+10);
    private Transform target;
    // Start is called before the first frame update
     public void Start()
    {    //target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();

    //Debug.Log(Camera.main.ScreenToWorldPoint(Screen.height/2));
      // player = GameObject.FindGameObjectsWithTag("player");
    Vector2 topRightCorner = new Vector2(1, 1);
     Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
    float height = edgeVector.y ;
    float width = edgeVector.x ;
      

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

        if ((transform.position.y > 0f) || (transform.position.x > 0f) ) 
        {
         transform.position = Vector2.MoveTowards(transform.position,new Vector3(-10f,-10f,0), 1 * Time.deltaTime);
        }


        

           
     
     //
     
        if ( (transform.position.y <= 0f) && (transform.position.x <= 0f))
        {
            transform.position = Vector2.MoveTowards(transform.position,target.position,Random.Range(speed, speed*2)* Time.deltaTime);
        }

     
    
    }



}

