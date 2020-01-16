using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootenemy : MonoBehaviour
{
    public GameObject prefab;
    float timebtwshots;
    public float starttimebtwshots;

    // Start is called before the first frame update
    void Start()
    {
       
        timebtwshots = starttimebtwshots;
    }

    // Update is called once per frame
    void Update()
    {       
        
        if(timebtwshots <= 0)
        {
            Instantiate(prefab,transform.position,Quaternion.identity);
               timebtwshots = starttimebtwshots;

        }
        else {
            timebtwshots -= Time.deltaTime;
        }
          
        
         
        
    }
}
