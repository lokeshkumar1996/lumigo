using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthdetails : MonoBehaviour
{

    int totalhealth;
    int totaldiamonds;
    public Text displaytothealth;
    public Text displaydiamonds;
    
    public Text error;
    // Start is called before the first frame update
    void Start()
    {
        totalhealth = PlayerPrefs.GetInt("health");
        totaldiamonds = PlayerPrefs.GetInt("diamonds");

        error.text = "1 life = 100 diamonds";
    }

    public void play()
    {
       //SceneManager.LoadScene("test4");
        GameObject.Find("healthpanel").SetActive(false);
        
            
        Time.timeScale = 1f; 
        GameObject.Find("player").GetComponent<playermove>().enabled =true;

       
    }

    // Update is called once per frame
    void Update()
    {
        displaytothealth.text = totalhealth.ToString("");        
        displaydiamonds.text = totaldiamonds.ToString("");

        if((PlayerPrefs.GetInt("diamonds") - 100) >= 0)
        error.text = "1 life = 100 diamonds";
        else
        error.text = "Not enough diamonds";
    }


    public void addhealth()
    {
        
       //SceneManager.LoadScene("test4");
        int diamonds = PlayerPrefs.GetInt("diamonds");
        

        if((diamonds - 100) > 0)
        {
            totaldiamonds  = diamonds - 100;
            PlayerPrefs.SetInt("diamonds",totaldiamonds);
            totalhealth = totalhealth + 1;
            PlayerPrefs.SetInt("health",totalhealth);

        }else
        {
          // show message;
          Debug.Log("not enough diamonds");
          error.text = "Not enough diamonds";
        }
        
        

       
    }
}
