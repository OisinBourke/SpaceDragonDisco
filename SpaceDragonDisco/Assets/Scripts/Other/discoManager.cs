using UnityEngine;
using System.Collections;

public class discoManager : MonoBehaviour {

    public GameObject music1;
    public GameObject music2;
    //public AudioClip sound1;
    //public AudioClip sound2;


	void Start () 
    {
	
	}
	
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            music1.audio.volume = 0;
            music2.audio.volume = 1;

        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            music1.audio.volume = 1;
            music2.audio.volume = 0;
        }
	
	}
}
