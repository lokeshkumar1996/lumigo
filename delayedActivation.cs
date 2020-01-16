using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayedActivation : MonoBehaviour
{
 
    public float timedelay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timedelay > 0){ timedelay -= Time.deltaTime;}
       
      if(timedelay <= 0)
        {
            gameObject.GetComponent<playermove>().enabled = true;
              // timebtwshots = starttimebtwshots;

        }
     
    }
}
