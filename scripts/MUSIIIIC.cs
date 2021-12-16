using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MUSIIIIC : MonoBehaviour
{

    [SerializeField] private AudioClip menuMusic;
    // music menu

    [SerializeField] private AudioClip lvlMusic;
    public AudioClip[] musicClips = new AudioClip[2];

    // music lvl

    [SerializeField] private AudioSource ASourse;
    //it's play music

    static private MUSIIIIC ints;

    protected virtual void Awake()
    {
        if(ints == null)
        {
            // зарегестрировать объект как синглтон если это перва€ ргистраци€ 
            ints = this;

            // не уничтожать инициированный экземпл€р при новой загрузке 
            DontDestroyOnLoad(this);

        }
        //уничтожаем кземпл€р если он инициализируетс€ второй раз
        else { Destroy(this); }
        return;
    }


    protected virtual void Start()
    {
        PlayMusicMenu();
    }



    /// <summary>
    /// Plays the music designed for the menus
    /// This method is static so that it can be called from anywhere in the code.
    /// </summary>
    static public void PlayMusicMenu()
    {
       if(ints != null)
        {
            if(ints.ASourse != null)
            {
                ints.ASourse.Stop();
                ints.ASourse.clip = ints.menuMusic;
                ints.ASourse.Play();

            }
            else
            {
                Debug.LogError("Unavailable MusicPlayer component");
            }
        }
    }


    /// <summary>
    /// Plays the music designed for outside menus
    /// This method is static so that it can be called from anywhere in the code.
    /// </summary>

    static public void PlayLVLMusic()
    {
        if(ints != null)
        {
            if(ints.ASourse != null)
            {
                ints.ASourse.Stop();
                if(RocketText.currentLvl == 3)
                ints.ASourse.clip = ints.musicClips[0];
                ints.ASourse.loop = true;
                if (RocketText.currentLvl == 4)
                ints.ASourse.clip = ints.musicClips[1];
                ints.ASourse.loop = true;
                ints.ASourse.Play();
            }
        }
    }

}
