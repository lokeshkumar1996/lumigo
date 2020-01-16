using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushemaway : MonoBehaviour
{
    // Start is called before the first frame update
   public float speed;
   public float playerpointdist;
   float height ;
   float width ;
   public GameObject points;
   public GameObject blast;
 
    

    //speed = Random.Range(speedintensity, speedintensity+10);
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
        
        Vector2 topRightCorner = new Vector2(1, 1);
      Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
      height = edgeVector.y - 4 ;
      width = edgeVector.x - 2;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      



     //speed = Random.Range(speedintensity, speedintensity+10); 
    if(Vector2.Distance(transform.position, target.position) < playerpointdist)
    {
      transform.position = Vector2.MoveTowards(transform.position,target.position, - speed * Time.deltaTime);
    }
    
    if (transform.position.x > (width) || transform.position.x < -(width) || transform.position.y > (height-3) || transform.position.y < -(height) ) 
    {
      Instantiate(points, new Vector3(Random.Range(-width, width),Random.Range(-height, height-4),0),  Quaternion.identity);
      Instantiate(blast, transform.position,  Quaternion.identity);
      
      GameObject.Find("player").GetComponent<destroyonhitplayer>().pointscount = GameObject.Find("player").GetComponent<destroyonhitplayer>().pointscount + 1;
      Destroy(gameObject);
    }
    }
}

