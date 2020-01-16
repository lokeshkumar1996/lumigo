using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alwaysplay : MonoBehaviour
{

    public AudioClip MusicClip;

    // the component that Unity uses to play your clip
    public AudioSource MusicSource;
    // Start is called before the first frame update
    void Start () {
        MusicSource.clip = MusicClip;
	}
	
	// Update is called once per frame
	void Update ()
    {
                    MusicSource.Play();	
	}
}
