using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenetransfer : MonoBehaviour
{
    
    public int health;
    public int levelind;
    public float timeended;
    GameObject player;
    GameObject timer;
    // Start is called before the first frame update

    

    // Update is called once per frame
    

    void Awake()
    {
        
        levelind = int.Parse(string.Concat(SceneManager.GetActiveScene().name[5], SceneManager.GetActiveScene().name[6]));
        DontDestroyOnLoad(this);
        player = GameObject.Find("player");
        timer = GameObject.Find("timer");

    }

    void FixedUpdate()
    {   
    if(player != null)
     health = player.GetComponent<destroyonhitplayer>().health;
    if(timer != null)
     timeended = timer.GetComponent<timer>().elapsed;
    }
}
