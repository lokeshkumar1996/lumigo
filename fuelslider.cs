using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuelslider : MonoBehaviour
{   
   
    public float fuellevel;
    public Slider fuelslide;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
  void FixedUpdate()
    {
       fuellevel= GameObject.Find("player").GetComponent<fueling>().fuel;
       fuelslide.value = fuellevel;
     //speed = Random.Range(speedintensity, speedintensity+10); 
    //if(Vector.Distance(transform.position, target.position)>3)
      
    }


}

