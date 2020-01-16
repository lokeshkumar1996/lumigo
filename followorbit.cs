﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followorbit : MonoBehaviour
{
     
     public GameObject sun;
     Transform center;
     public Vector3 axis = Vector3.up;
     public Vector3 desiredPosition;
     public float radius ;
    // public float radiusSpeed ;
     public float rotationSpeed ;
 
     void Start () {
        
         center = sun.transform;
         transform.position = (transform.position - center.position).normalized * radius + center.position;
         
     }
     
     void Update () {
         transform.RotateAround (center.position, axis, rotationSpeed * 2 * Time.deltaTime);
         //desiredPosition = (transform.position - center.position).normalized * radius + center.position;
        // transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
     }
 }
