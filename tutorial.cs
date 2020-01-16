using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tutorial : MonoBehaviour
{
  public GameObject first;
  public  GameObject second;
  public  GameObject third;
  public GameObject fourth;
  public GameObject timer;
  public GameObject fifth;
 



// Start is called before the first frame update
   public float timerinsec1 = 0.1f;
   public float timerinsec2 = 2f;
   public float timerinsec3 = 5f;
   public float timerinsec4 = 5f;
    float elapsed = 0;
    

    // Update is called once per frame
    public void FixedUpdate()
    {
        // Debug.Log("time"); 
        elapsed += Time.deltaTime;

        if (elapsed >= timerinsec1)
        {
           if(first != null) 
            first.SetActive(true);
    
        } 

        if (elapsed >= timerinsec2)
        {
            Destroy(first);
            if(second != null) 
            second.SetActive(true);
    
        } 
        if (elapsed >= timerinsec3)
        {   
            Destroy(second);
            if(third != null) 
            third.SetActive(true);
            
    
        } 
         if (elapsed >= timerinsec4)
        {
            Destroy(third);
            fifth.SetActive(true);
            timer.GetComponent<timer>().elapsed = 0;
            fourth.SetActive(true);
            
    
        } 


    }
}
