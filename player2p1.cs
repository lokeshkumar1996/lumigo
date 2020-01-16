using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2p1 : MonoBehaviour
{   
    public int p1pointcount;
    public int p1health;
    // Start is called before the first frame update
    void Start()
    {
        p1pointcount = 0;
        p1health = 3;
        
    }

    // Update is called once per frame
    void Update()
    {


         
    }

    void OnCollisionEnter2D(Collision2D collision)
      {    
        if (collision.gameObject.tag == "2ppoints" )
        {
            FindObjectOfType<AudioManager>().Play("pointscollected");
             p1pointcount = p1pointcount + 1;
        } 

        if (collision.gameObject.tag == "2pvanishpoints" )
        {
            FindObjectOfType<AudioManager>().Play("pointscollected");
             p1pointcount = p1pointcount + 2;
        }

        if (collision.gameObject.tag == "2pmovingpoints" )
        {
            FindObjectOfType<AudioManager>().Play("pointscollected");
             p1pointcount = p1pointcount + 3;
        }

        if (collision.gameObject.tag == "2ppushempoints" )
        {
            FindObjectOfType<AudioManager>().Play("pointscollected");
             p1pointcount = p1pointcount + 5;
        }
        if (collision.gameObject.tag == "enemy" )
        {
          Debug.Log("hitby enemy");
           // FindObjectOfType<AudioManager>().Play("pointscollected");
             p1health = p1health - 1 ;
        }
        
      }
}
