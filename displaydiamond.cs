using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displaydiamond : MonoBehaviour
{
    public Text diamondcounter;
    
    int curdiamond;
    // Start is called before the first frame update
    void Start()
    {
     //l.loaddata();
      curdiamond = AudioManager.instance.diamonds;
      diamondcounter.text = curdiamond.ToString("0"); 
    }

    // Update is called once per frame 
    
     void Update()
    {
      
      curdiamond = AudioManager.instance.diamonds;
      diamondcounter.text = curdiamond.ToString("0"); 
    }
}
