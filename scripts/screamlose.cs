using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screamlose : MonoBehaviour
{
    AudioSource LoseScream;
    void Start()
    {
        LoseScream = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void SCREAM()
    {
        LoseScream.Play();
    }
}
