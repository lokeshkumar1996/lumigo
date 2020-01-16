using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelno : MonoBehaviour
{
    // Start is called before the first frame update
     public Text levelnum;
   


    void FixedUpdate()
    {   
           
      levelnum.text = string.Concat(SceneManager.GetActiveScene().name[5], SceneManager.GetActiveScene().name[6]); 
       //levelname = SceneManager.GetActiveScene().name[];


    }
}
