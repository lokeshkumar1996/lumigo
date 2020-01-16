using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startupmanagerlogo : MonoBehaviour {

    // Use this for initialization
    private IEnumerator Start () 
    {
        while (!LocalizationManager.instance.GetIsReady ()) 
        {
            yield return null;
        }

       // SceneManager.LoadScene ("MenuScreen");
       //GameObject.Find("back").GetComponent<Button>().interactable = true;
       
        SceneManager.LoadScene("menu1");
    }

}
