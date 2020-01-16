using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followeliporbit : MonoBehaviour
{
     
     public GameObject sun;
     Transform center;
     public Vector3 axis = Vector3.up;
     public Vector3 desiredPosition;
     public float radius ;
    // public float radiusSpeed ;
     public float rotationSpeed ;
     public int followdistance;
    public int followspeed;
 
     void Start () {
        
         
         //transform.position = (transform.position - center.position).normalized * radius + center.position;
         
     }
     
     void Update () {

         center = sun.transform;
         
         if(Vector2.Distance(transform.position, center.position) > followdistance)
         {
            transform.position = Vector2.MoveTowards(transform.position,center.position,followspeed * Time.deltaTime);
           
         }
         transform.RotateAround (center.position, axis, rotationSpeed * 2 * Time.deltaTime);
         //desiredPosition = (transform.position - center.position).normalized * radius + center.position;
        // transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
     }
 }
