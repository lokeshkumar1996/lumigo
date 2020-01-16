using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{   public GameObject enemytospawn;
    
    // Start is called before the first frame update
   
    private IEnumerator Start () 
    {
        
       
        yield return new WaitForSeconds(1.2f);

       

          
            Instantiate(enemytospawn, transform.position,  Quaternion.identity);
            
            //GameObject.Find("pointsaudio").GetComponent<AudioSource>().Play();
           // FindObjectOfType<AudioManager>().Play("pointscollected");
            
             Destroy(gameObject); 
        
 
    }

    
}
