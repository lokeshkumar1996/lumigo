using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class borderonoff : MonoBehaviour
{
    public Image borderimg;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("border",0)== 0)
        {
           borderimg.enabled = false;
        }else borderimg.enabled = true;
    }

    // Update is called once per frame
    
}
