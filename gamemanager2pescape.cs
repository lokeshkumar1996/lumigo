using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager2pescape : MonoBehaviour
{   
    public float elapsed ;  
    public GameObject[] enemies;
    bool enemy1 = false;
    bool enemy2 = false;
    bool enemy3 = false;
    bool enemy4 = false;
    bool enemy5 = false;
    bool enemy6 = false;
    bool enemy7 = false;
    bool enemy8 = false;
    bool enemy9 = false;
    bool enemy10 = false;
    bool enemy11= false;
    

    
    
    float height ;
    float width ;


    // Start is called before the first frame update
    void Start()
    {
        
        Vector2 topRightCorner = new Vector2(1, 1);
                
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if(elapsed > 2 && enemy1 == false )
        {
             Instantiate(enemies[0], new Vector3(0,0,0),  Quaternion.identity);              
             enemy1 = true;
        }
        if(elapsed > 10 && !enemy2 )
        {
             Instantiate(enemies[1], new Vector3(0,0,0),  Quaternion.identity);              
             enemy2 = true;
        }
        if(elapsed > 15 && !enemy3 )
        {
             Instantiate(enemies[2], new Vector3(0,0,0),  Quaternion.identity);              
             enemy3 = true;
        }
        if(elapsed > 20 && !enemy4 )
        {
             Instantiate(enemies[3], new Vector3(0,0,0),  Quaternion.identity);              
             enemy4 = true;
        }
        if(elapsed > 30 && !enemy5 )
        {
             Instantiate(enemies[4], new Vector3(0,0,0),  Quaternion.identity);              
             enemy5 = true;
        }
        if(elapsed > 40 && !enemy6 )
        {
             Instantiate(enemies[5], new Vector3(0,0,0),  Quaternion.identity);              
             enemy6 = true;
        }
        if(elapsed > 45 && !enemy7 )
        {
             Instantiate(enemies[6], new Vector3(0,0,0),  Quaternion.identity);              
             enemy7 = true;
        }
        if(elapsed > 50 && !enemy8 )
        {
             Instantiate(enemies[7], new Vector3(0,0,0),  Quaternion.identity);              
             enemy8 = true;
        }
        if(elapsed > 55 && !enemy9 )
        {
             Instantiate(enemies[8], new Vector3(0,0,0),  Quaternion.identity);              
             enemy9 = true;
        }
        if(elapsed > 60 && !enemy10 )
        {
             Instantiate(enemies[9], new Vector3(0,0,0),  Quaternion.identity);              
             enemy10 = true;
        }
        if(elapsed > 120 && !enemy11 )
        {
             Instantiate(enemies[10], new Vector3(0,0,0),  Quaternion.identity);              
             enemy11 = true;
        }

        



    }
}
