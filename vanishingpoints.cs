
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanishingpoints : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject points;
    public GameObject blast;
    

    float height ;
    float width ;
    float elapsed = 1; 
    public float frequency = 10;
   
  void Start()
  {
    Vector2 topRightCorner = new Vector2(1, 1);
     Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
      height = edgeVector.y - 4 ;
      width = edgeVector.x - 2;
  }
    

    void Update()
    {
      
      
      
      


        elapsed += Time.deltaTime;

        if ((int)elapsed % frequency  == 0)
        {   

          float yrange;
          
          if(transform.position.y >= 0)
          {
            yrange =Random.Range(-height,0);
          }else  yrange =Random.Range(height-4,0);

          
            Instantiate(points, new Vector3(Random.Range(-width,width),yrange,0),  Quaternion.identity);
          Instantiate(blast, transform.position,  Quaternion.identity);

          if((GameObject.Find("vanishcount") != null) &&  (points.tag == "points") )
         {
           GameObject.Find("vanishcount").GetComponent<vanishcounter>().vanish += 1;
         }
          

           
            FindObjectOfType<AudioManager>().Play("vanishpoint");
            Destroy(gameObject);             
        }

    



    }
 
  

     
}
