using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class TextManager : MonoBehaviour
{
   
    public TMP_Text TEXToil;

    private string stringBENZIN;

    // Start is called before the first frame update
    void Start()
    {
        TEXToil = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        ShowMe();
    }


    void ShowMe()
    {
        stringBENZIN = RocketText.BENSIN.ToString();
        TEXToil.text = $"your OIL: {stringBENZIN}%";
    }

    public void BensinOn()
    {
        var numberOIL = RocketText.bensin -= 1 * 0.2f;
        RocketText.BENSIN = (int)numberOIL;
    }


    public void BensinUp()
    {
        RocketText.bensin = 100;
    }
        

}
