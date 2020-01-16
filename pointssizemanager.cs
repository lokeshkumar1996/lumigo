using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointssizemanager : MonoBehaviour
{
    float height ;
    float width ;
    float aspectratio;
    float stdheight;
    float stdwidth;
    public float initialscale;
    float stdscalex;
    float stdscaley;
    float stdscalez;

    // Start is called before the first frame update
    void Start()
    {
        stdheight = 56f;
        stdwidth = 56f;

       Vector2 topRightCorner = new Vector2(1, 1);
     Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
      height = (edgeVector.y)*2 ;
      width = (edgeVector.x)*2 ; 
      stdscalex = initialscale;
      stdscaley = initialscale;
      stdscalez = initialscale;

    }

    // Update is called once per frame
    void Update()
    {
       Vector2 topRightCorner = new Vector2(1, 1);
     Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);   
      height = (edgeVector.y)*2 ;
      width = (edgeVector.x)*2 ; 

        aspectratio = height/width;

        if(aspectratio >= 1)
        {
            float scalefactor = height/stdheight;
            
            transform.localScale = new Vector3(stdscalex * scalefactor, stdscaley * scalefactor, stdscalez * scalefactor);
        }else
        {
            float scalefactor = width/stdwidth;
            transform.localScale = new Vector3(stdscalex * scalefactor, stdscaley * scalefactor, stdscalez * scalefactor);

        }

        

    }
}