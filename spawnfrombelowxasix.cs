using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnfrombelowxasix : MonoBehaviour
{
    public GameObject prefab;
    float timebtwshots;
    public float starttimebtwshots;
    public int numberofprojectile;
    public int radius;
    

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


        
        for (int i = 0; i < numberofprojectile; i++)
        {
        float angle = i * Mathf.PI*2f / numberofprojectile;
        if(angle > Mathf.PI*1f){
         Vector3 newPos = new Vector3(Mathf.Cos(angle)*radius, Mathf.Sin(angle)*radius, 0);
        GameObject go = Instantiate(prefab, newPos+transform.position, Quaternion.identity);
        }


        }
               timebtwshots = starttimebtwshots;



        }
        else {
            timebtwshots -= Time.deltaTime;
        }
          
        
         
        
    }
}