using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropobstacle : MonoBehaviour
{
   // public GameObject prefab;
    float timebtwshots;
    public float starttimebtwshots;
     public GameObject[] prefeb;

    // Start is called before the first frame update
    void Start()
    {
       
        timebtwshots = starttimebtwshots;
    }
    

    // Update is called once per frame
    void Update()
    {       
        
        if(timebtwshots <= 0)
        {    //if (Input.touchCount > 0  )   
            //{   
            int prefeb_num = Random.Range(0,prefeb.Length-1);
            Instantiate(prefeb[prefeb_num],transform.position,Quaternion.identity);
           // }
               timebtwshots = starttimebtwshots;

        }
        else {
            timebtwshots -= Time.deltaTime;
        }
          
        
         
        
    }
}