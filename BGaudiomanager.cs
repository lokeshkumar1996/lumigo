using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class BGaudiomanager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static BGaudiomanager instance;

    public AudioMixerGroup BGMixer;

    //public AudioClip[] mediumfast;
    //public AudioClip[] veryslow;
    //public AudioClip[] veryfast;
    //public AudioClip[] slow;
    
    public AudioClip mainmenu;
    public AudioClip gameover;
    public AudioClip levelselct;
    public AudioSource audioSource;
    
    
    
    
    void Awake()
    {

        if(instance == null)
            instance =this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        audioSource = this.GetComponent<AudioSource>();    
          
        audioSource.outputAudioMixerGroup = BGMixer;
          audioSource.loop = true;

          SceneManager.sceneLoaded += OnSceneLoaded; 
         
    }
   

    // Update is called once per frame
   // void Update()
  //  {    
       // SceneManager.sceneLoaded += OnSceneLoaded; 
        
   // }
    
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        
        Resources.UnloadUnusedAssets();
        int ind = SceneManager.GetActiveScene().buildIndex;

        audioSource.Stop(); 

        //mainmenu
        if(ind== 1)
        {
            audioSource.clip = mainmenu;
                audioSource.Play();
                PlayerPrefs.SetInt("scenechanged",0);
        }
        //gameover
        if(ind==163)
        {
            PlayerPrefs.SetInt("scenechanged",1);
            audioSource.clip = gameover;
                audioSource.Play();
                
        }
        
        //levelselect
        if(ind==164)
        {
            audioSource.clip = levelselct;
                audioSource.Play();
                PlayerPrefs.SetInt("scenechanged",0);
        }
        //level complete
        if(ind==165)
        {
           PlayerPrefs.SetInt("scenechanged",1);
        }

        if(ind > 1 && ind < 161) 
        {
            if(ind %2 != 0)
            {   
                 PlayerPrefs.SetInt("scenechanged",0);
                //levels
                int id = (ind-1)/2;

                //mediiumfast levels
                if(id==1 || id==3 || id==5 || id==8 || id==9 || id==11 || id==12 || id==15 || id==16 || id==19 || id==21 || id==23 || id==29 || id==34 || id==35 || id==43 || id==38 || id==50 || id==51 || id==60 || id==61 || id==62 || id==63 || id==67 || id==68 || id==71 || id==72 || id==73 )
                {
                
                int num = Random.Range(1,10);
                string filename = string.Concat("mf", num.ToString("0")); 
                Debug.Log("fielname="+filename);                
                AudioClip mediumfast = Resources.Load(filename) as AudioClip;
                audioSource.clip = mediumfast;             
                audioSource.Play();
                }

                //veryslow levels

                if( id==2 || id==6 || id==46 || id==47 || id==49 || id==52 || id==54 || id==55 || id==56 || id==65 || id==31)
                {
                   
                    int num = Random.Range(1,6);
                    string filename = string.Concat("vs", num.ToString("0")); 
                    Debug.Log("fielname="+filename);                
                    AudioClip veryslow = Resources.Load(filename) as AudioClip;
                    audioSource.clip = veryslow;
                    audioSource.Play();
                }

                //slow levels & for 2player escape
                if(id==167 || id==13 || id==17 || id==22 || id==25 || id==26 || id==27 || id==28 || id==30 || id==33 || id==36 || id==37 || id==39 || id==40 || id==41 || id==44 || id==45 || id==48 || id==57)
                {
                   
                    int num = Random.Range(1,6);
                    string filename = string.Concat("s", num.ToString("0")); 
                    Debug.Log("fielname="+filename);                
                    AudioClip slow = Resources.Load(filename) as AudioClip;
                    audioSource.clip = slow;
                    audioSource.Play();
                }

                //veryfast levels
                if(id==4 || id==7 || id==10 || id==14 || id==18 || id==20 || id==24 || id==32 || id==42 || id==58 || id==59 || id==64 || id==66 || id==69 || id==70 || id==74 || id==75 || id==76 || id==77 || id==78 || id==79 || id==80)
                {
                    
                    int num = Random.Range(1,6);
                    string filename = string.Concat("vf", num.ToString("0")); 
                    Debug.Log("fielname="+filename);                
                    AudioClip veryfast = Resources.Load(filename) as AudioClip;
                    audioSource.clip = veryfast;
                    audioSource.Play();
                }
                                
            }
            else
            {  PlayerPrefs.SetInt("scenechanged",1);  //level description screen            
                audioSource.clip = mainmenu;
                audioSource.Play();
                              
            } 
        }
         

    }
      



    
}
