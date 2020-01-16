using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startupmanagerinit : MonoBehaviour {

    // Use this for initialization
    private IEnumerator Start () 
    {
        
        while (!LocalizationManager.instance.GetIsReady ()) 
        {
            yield return null;
            Debug.Log("start");
        }
        //yield return new WaitForSeconds(1.5f);

        //GameObject.Find("start").GetComponent<Button>().interactable = true;
        
 
    }

}