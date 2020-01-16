using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyonhitpoints : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject points;
    public GameObject blast;
    float height ;
    float width ;

    void Start()
    {
      Vector2 topRightCorner = new Vector2(1, 1);
     Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
      height = edgeVector.y-4;
      width = edgeVector.x - 2;
    }

    void Update()
    {
      
    }
    // Start is called before the first frame update
   void OnCollisionEnter2D(Collision2D collision)
    {   
         if (collision.gameObject.tag == "player")
        {
          float yrange;
          
          if(transform.position.y >= 0)
          {
            yrange =Random.Range(-height,0);
          }else  yrange =Random.Range(height-4,0);

          
            Instantiate(points, new Vector3(Random.Range(-width,width),yrange,0),  Quaternion.identity);
            Instantiate(blast, transform.position,  Quaternion.identity);
            //GameObject.Find("pointsaudio").GetComponent<AudioSource>().Play();
           // FindObjectOfType<AudioManager>().Play("pointscollected");
            
             Destroy(gameObject);


            
        }   
        
    }
}
