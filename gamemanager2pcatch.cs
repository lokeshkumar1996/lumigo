using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager2pcatch : MonoBehaviour
{   
    public float elapsed ;  
    public GameObject[] points;
    bool points2 = false;
    bool points3 = false;
    bool points1 = false;
    float height ;
    float width ;


    // Start is called before the first frame update
    void Start()
    {

        Vector2 topRightCorner = new Vector2(1, 1);
        Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
        height = edgeVector.y - 4 ;
        width = edgeVector.x - 2 ;
       
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if(elapsed > 20 && points2  == false )
        {
            
             Instantiate(points[1], new Vector3(Random.Range(-width, width),Random.Range(-height, height),0),  Quaternion.identity);
             points2 = true;
        }

        if(elapsed > 30 && points3  == false )
        {
            Instantiate(points[2], new Vector3(Random.Range(-width, width),Random.Range(-height, height),0),  Quaternion.identity);
             points3 = true;
        }

        if(elapsed > 2 && points1 == false)
        {
            Debug.Log("point1");
              Instantiate(points[0], new Vector3(Random.Range(-width, width),Random.Range(-height, height),0),  Quaternion.identity);
             points1 = true;
        }

    }
}
