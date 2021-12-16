using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winEffect : MonoBehaviour
{

    public ParticleSystem PSC;


    // Start is called before the first frame update
    void Start()
    {
        PSC = GetComponent<ParticleSystem>();    
    }

   public void startPSC()
    {
        PSC.Play();
    }
}
