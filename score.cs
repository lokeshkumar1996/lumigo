using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scorecount;


    void FixedUpdate()
    {   
           
      scorecount.text = GameObject.Find("player").GetComponent<destroyonhitplayer>().pointscount.ToString("00");

    }
}
