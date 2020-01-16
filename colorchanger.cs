using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorchanger : MonoBehaviour
{
    public GameObject[] colorchangeable;
     public GameObject[] colorchangetext;
    // Start is called before the first frame update
    void Start()
    {
       var colortochange = Random.ColorHSV(0f, 1f, .4f, .5f, 1f, 1f,1f,1f);
        colorchangeable = GameObject.FindGameObjectsWithTag("changecolor");
        //gameObject.GetComponent<Image>().color = Random.ColorHSV(0f, 1f);
        foreach (GameObject colorchangeable in colorchangeable)
        {
            colorchangeable.GetComponent<Image>().color = colortochange;
        }

        colorchangetext = GameObject.FindGameObjectsWithTag("changecolortext");
        foreach (GameObject t in colorchangetext)
        {
            t.GetComponent<Text>().color = colortochange;
        }

        
      
    }

    // Update is called once per frame
    void Update()
    {
        
  
        // Pick a random, saturated and not-too-dark color
        
    
    }
}
