using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpanel2p : MonoBehaviour
{   
    
    [SerializeField]
    GameObject  health1;
    [SerializeField]
    GameObject  health2;
    [SerializeField]
    GameObject  health3;
    public int playerhealth;
    public GameObject Levelcomplete;
    public GameObject player;

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


         playerhealth = player.GetComponent<player2p1>().p1health ;

        if(playerhealth >= 3)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
        }

        if(playerhealth ==2)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(false);
            
        }

         if(playerhealth ==1)
        {
            health1.SetActive(true);
            health2.SetActive(false);
            health3.SetActive(false);
                       
        }
         if(playerhealth <=0)
        {
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(false);
            GameObject.Find("gamecontroller").GetComponent<gamecontroller2player>().winner = 2;
            Levelcomplete.SetActive(true);
            Destroy( GameObject.Find("player1"));
            Destroy( GameObject.Find("player2"));
                       
        }

    }
}
