using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{

    //создать переключатель....
    // при активе,делаем неактив 
    // запуск при начальном запуске секции 

    int numberAfterDissable = 2; // количество заргузок после уничтожени€ анимации с кэпЋостом
    //int correctNumber = 1;  
    bool GetMePause ;
    




    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 0;
        GetMePause = true;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        

        if (GetMePause)
         {
             Time.timeScale = 0;
             GetComponent<Animator>().SetBool("show",GetMePause);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GetComponent<Animator>().SetBool("show", GetMePause);
            numberAfterDissable -= 1;
            if (numberAfterDissable == 0)
            {
               
                GetComponent<Animator>().enabled = false;
            }
            GetMePause = !GetMePause;
            Time.timeScale = GetMePause ? 0 : 1; /// террнарный оператор. если оператор тру то будет ноль(в нашем случае),если наоборот,то 1 ((( услови€ ? : if true - 0 : else - 0 
            Debug.Log(222);
            GetComponent<Animator>().SetBool("show", GetMePause);
        }
    }
}
