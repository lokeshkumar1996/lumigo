using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileinalldirection2 : MonoBehaviour
{
    public float speed;
     //Transform hit;
     Vector2 targetdir;
     public GameObject[] player;
     private Transform target;
     public Vector2 direction;

    
     float destroytimer = 5f;


    // Start is called before the first frame update
    void Start()
    {
      // hit = GameObject.Find("player").transform;
       //targetdir = new Vector2(hit.position.x, hit.position.y);

       
        target = GameObject.Find("movingenemyshootalldir").transform;
       //GameObject.Find("bubble").GetComponent<AudioSource>().Play();


     targetdir = new Vector2(target.position.x, target.position.y);


    Vector3 difference =  target.position - transform.position;

    direction = difference/(difference.magnitude);
    direction.Normalize();
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = Vector2.MoveTowards(transform.position,targetdir,speed*Time.deltaTime);
        gameObject.GetComponent<Rigidbody2D>().velocity = -direction * speed;

          if(destroytimer <= 0)
        {
             Destroy(gameObject);

        }
        else {
            destroytimer -= Time.deltaTime;
        }




        
    }
}

