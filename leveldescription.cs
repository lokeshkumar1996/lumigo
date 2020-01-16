using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class leveldescription : MonoBehaviour
{
    // Start is called before the first frame update
    //public Text leveldescript;

     string levelind; 
     string limitkey;
     public Text limit;
    // Start is called before the first frame update
    //public Text description;
    


    public void Start()
    {
      levelind = string.Concat(SceneManager.GetActiveScene().name[5], SceneManager.GetActiveScene().name[6]);
      limitkey = string.Concat("levelimit", levelind);

      //Debug.Log(LocalizationManager.instance.GetLocalizedValue(limitkey));
      // Debug.Log(limitkey);
     // GameObject.Find("levellimt").GetComponent<LocalizedText>().key = limitkey;
      limit.text = LocalizationManager.instance.GetLocalizedValue(limitkey);
      

       //Destroy(GameObject.Find("descriptiontrans"));
       

    }

   


}
