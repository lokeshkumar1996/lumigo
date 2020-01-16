using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthpannel : MonoBehaviour
{
    
    //public GameObject healthpanel;
    
    [SerializeField]
    GameObject  health1;
    [SerializeField]
    GameObject  health2;
    [SerializeField]
    GameObject  health3;
    // Start is called before the first frame update
    void Start()
    {
     
     
     //health1 = healthpanel.transform.GetChild(0).gameObject;
     //health2 = healthpanel.transform.GetChild(1).gameObject;
    // health3 = healthpanel.transform.GetChild(2).gameObject;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("health") >= 3)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
        }

        if(PlayerPrefs.GetInt("health") ==2)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(false);
            
        }

         if(PlayerPrefs.GetInt("health") ==1)
        {
            health1.SetActive(true);
            health2.SetActive(false);
            health3.SetActive(false);
                       
        }
         if(PlayerPrefs.GetInt("health") <=0)
        {
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(false);
                       
        }

    }

    


}
