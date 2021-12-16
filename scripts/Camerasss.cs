using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerasss : MonoBehaviour
{
    [SerializeField] float minFoV = 38;
    [SerializeField] float maxFoV = 70;
    [SerializeField] float speedFoV=0.1f;
    [SerializeField] Vector3 positionCamera;
    public AudioSource audioRocket;
    Camera GOplease;
    float inicialFOV;


    public Transform myRocket;


    void Start()
    {
        audioRocket = GetComponent<AudioSource>();
        GOplease = GetComponent<Camera>();
        inicialFOV = GOplease.fieldOfView;
    }

    private void LateUpdate()
    {
       transform.position = myRocket.transform.position + positionCamera; 
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

   
    public void GiveHight()
    {
        inicialFOV = GOplease.fieldOfView;
       if(inicialFOV < maxFoV)
        {
            GOplease.fieldOfView += 1 * speedFoV;
            if (inicialFOV == maxFoV)
            {
                Debug.Log(2);
                GOplease.fieldOfView = maxFoV;
               
            }
        }




    }
    public void GiveHiht()
    {
        inicialFOV = GOplease.fieldOfView;
        if (inicialFOV > minFoV)
        {
            GOplease.fieldOfView -= 1 * speedFoV;
            if (inicialFOV == minFoV)
            {
                GOplease.fieldOfView = minFoV;
            }
        }
    }

}
