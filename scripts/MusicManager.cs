using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public static MusicManager inst = null;

    // под каждый уровень создать скрипт с донтдестройќнЋоад с отдельной музыкой 

    public List<AudioClip> music = new List<AudioClip>();
    public AudioSource player;


    public void Reload(MusicManager newinst)
    {
        this.music = newinst.music;
        this.Start();
    }

    public void Start()
    {
        if(inst == null)
        {
            player = this.gameObject.AddComponent<AudioSource>();
            DontDestroyOnLoad(this);

            inst = this;
        }

        else 
        { 
        if(inst.music == music)
            {
                return;
            }

            inst.Reload(this);
                       
        }
        if (inst != this) return;

        player.loop = true;
       
    }


    public void UpdateMusic()
    {
        if (RocketText.currentLvl == 1)
        {
            Debug.Log("IT WORKS go first");

            // Destroy(gameObject);
            player.clip = music[1];
        }
        if (RocketText.currentLvl == 3)
        {
            Debug.Log("IT WORKS go firs");

            // Destroy(gameObject);
            player.clip = music[2];
        }

        player.clip = music[RocketText.currentLvl];


        player.Play();

    }


    // [SerializeField]public  AudioSource trans;
    //  [SerializeField]public AudioSource neylon;
    //  private static MusicManager manager;

    /*
        void Awake()
        {

                GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

                if (objs.Length > 1)
                {
                    Destroy(this.gameObject);
                }

                DontDestroyOnLoad(this.gameObject);


        }



        private void Start()
        {
            //trans = GetComponent<AudioSource>();
            //neylon = GetComponent<AudioSource>();


        }



      /*  public void MusicPlayer()
        {
            if (RocketText.currentLvl == 3)
            {
                trans.Play();
            }

            else 
            { neylon.Play(); } 
        }
      */


    void Experience()
    {
        /*using UnityEngine;
  
  public class DontDestroy : MonoBehaviour 
  {
      private static DontDestroy original;
      private void Awake()
      {     
          if (original != this )
          {
              if( original != null )
                  Destroy(original.gameObject);
              DontDestroyOnLoad(gameObject);
              original = this;
          }
      }
  }
         
    }
        */
    }
}
