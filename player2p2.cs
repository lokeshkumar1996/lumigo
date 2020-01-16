using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2p2 : MonoBehaviour
{   
    public int p2pointcount;
    public int p2health;
    // Start is called before the first frame update
    void Start()
    {
        p2pointcount = 0;
        p2health = 3;
       

       
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
             p2pointcount = p2pointcount + 1;
        } 

        if (collision.gameObject.tag == "2pvanishpoints" )
        {
            FindObjectOfType<AudioManager>().Play("pointscollected");
             p2pointcount = p2pointcount + 2;
        }

        if (collision.gameObject.tag == "2pmovingpoints" )
        {
            FindObjectOfType<AudioManager>().Play("pointscollected");
             p2pointcount = p2pointcount + 3;
        }

        if (collision.gameObject.tag == "2ppushempoints" )
        {
            FindObjectOfType<AudioManager>().Play("pointscollected");
             p2pointcount = p2pointcount + 5;
        }
        if (collision.gameObject.tag == "enemy" )
        {
           // FindObjectOfType<AudioManager>().Play("pointscollected");
             p2health = p2health - 1 ;
        }
        
      }
}

