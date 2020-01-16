using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanishingpoint1sec : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject points;
    public GameObject blast;

    float height ;
    float width ;
    float elapsed =1 ; 
    float elapsechange=2;
    
    void Start()
    {
     gameObject.GetComponent<SpriteRenderer>().enabled = true;

     Vector2 topRightCorner = new Vector2(1, 1);
     Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
      height = edgeVector.y - 4 ;
      width = edgeVector.x - 2;
    }

   void Update()
    {
      


      elapsed += Time.deltaTime;

        if ((int)elapsed == elapsechange)
        {   
            FindObjectOfType<AudioManager>().Play("vanishpoint");
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Invoke( "spawnpoints", .4f );
          //Instantiate(points, new Vector3(Random.Range(-width, width),Random.Range(-height, height),0),  Quaternion.identity);
          Instantiate(blast, transform.position,  Quaternion.identity);
          
          if((GameObject.Find("vanishcount") != null) && (points.tag == "points"))
         {
           GameObject.Find("vanishcount").GetComponent<vanishcounter>().vanish += 1;
         }
         
           elapsechange += 1; 
           Destroy(gameObject, .5f);  
            elapsechange += 1;   
             //vanishcount += 1;        
        }

    }

    

    void spawnpoints()
    {
      Instantiate(points, new Vector3(Random.Range(-width, width),Random.Range(-height, height-4),0),  Quaternion.identity);
    }

 
  

     
}
