using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAmerasFor2LVL : MonoBehaviour
{    
    [SerializeField] Vector3 positionCamera;
    public AudioSource audioRocket;
   


    void Start()
    {
        audioRocket = GetComponent<AudioSource>();
        
        
    }



    public void StartAudio()
    {
        if (!audioRocket.isPlaying)
        {
            audioRocket.Play();
        }
    }

    public void EndSound()
    {
        audioRocket.Stop();
    }
}