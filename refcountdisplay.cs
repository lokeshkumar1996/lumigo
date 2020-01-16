using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class refcountdisplay : MonoBehaviour
{
    public Text count;
    // Start is called before the first frame update
    void Start()
    {
        count.text = GameObject.Find("levelmenu").GetComponent<levelscreen>().referalcount.ToString("0");
    }

    // Update is called once per frame
    
}
