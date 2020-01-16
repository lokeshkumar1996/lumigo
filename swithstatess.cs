using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swithstatess : MonoBehaviour
{

    float timebtwshots;
    public int releasetime;
    
    float elapsed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if((int)elapsed % releasetime == 0)
        {
        gameObject.transform.GetChild(0).gameObject.SetActive(false); //point
        gameObject.transform.GetChild(1).gameObject.SetActive(true);  //enemy
        }
        else
        {
         gameObject.transform.GetChild(0).gameObject.SetActive(true); // point
         gameObject.transform.GetChild(1).gameObject.SetActive(false);   //enemy
        }
    }

     
}
