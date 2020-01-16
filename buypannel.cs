using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buypannel : MonoBehaviour
{
   //public GameObject netcheckpanel;
    // Start is called before the first frame update
    /*private IEnumerator Start ()
    {
        while (Application.internetReachability == NetworkReachability.NotReachable) 
        {
            yield return null;
            Debug.Log("no nework");
            netcheckpanel.SetActive(true);
            
        }
        //yield return new WaitForSeconds(1.5f);
            
        netcheckpanel.SetActive(false);
                    
    }*/

    // Start is called before the first frame update
    public void play()
    {
       //SceneManager.LoadScene("test4");
        GameObject.Find("buypannel").SetActive(false);
        
            
        Time.timeScale = 1f; 
        GameObject.Find("player").GetComponent<playermove>().enabled =true;

       
    }

    public void diamond500()
    {
       GameObject.Find("Purchaser").GetComponent<Purchaser>().Buydiamonds1();
    }

    public void diamond2000()
    {
        GameObject.Find("Purchaser").GetComponent<Purchaser>().Buydiamonds2();
    }

     public void diamond5000()
    {
        GameObject.Find("Purchaser").GetComponent<Purchaser>().Buydiamonds3();
    }


    public void unlockalllevel()
    {
       GameObject.Find("Purchaser").GetComponent<Purchaser>().Buyunlock();
    }

    public void getnoads()
    {
       GameObject.Find("Purchaser").GetComponent<Purchaser>().Buynoads();
    }

}
