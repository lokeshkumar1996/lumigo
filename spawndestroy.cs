using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawndestroy : MonoBehaviour
{

    public float timerinsec = 5f;
    float elapsed = 0;
    public float speed;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(target, new Vector3(Random.Range(-11f, 11.0f),Random.Range(-22f, 17.5f),0),  Quaternion.identity);
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        // Debug.Log("time"); 
        elapsed += Time.deltaTime;

        if (elapsed >= timerinsec)
        {
           

             Destroy(target);
            //function to execute in loop
            Instantiate(target, new Vector3(Random.Range(-11f, 11.0f),Random.Range(-22f, 17.5f),0),  Quaternion.identity);
            elapsed = 0f;

            //function to execute in loop

            
        }    
    }

}
