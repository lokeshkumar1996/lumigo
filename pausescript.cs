using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausescript : MonoBehaviour
{
    public GameObject resumepannel;
    // Start is called before the first frame update
     public void pause()
    {
       // Debug.Log("resumepannel");
       //SceneManager.LoadScene("test4");
       GameObject.Find("player").GetComponent<playermove>().enabled =false;
       resumepannel.SetActive(true);
        //resumepannel.SetActive(true);   
        Time.timeScale = 0f; 

    }
}
