using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexPassCheck : MonoBehaviour
{
    public GameObject NoPass;
    public GameObject Pass;
    

    public void Check()
    {
        int var = PlayerPrefs.GetInt("PassHek");
        if(var == 1)
        {
            Pass.SetActive(true);
        }
        if(var != 1)
        {
            NoPass.SetActive(true);
        }
    }

    public void Start()
    {
        int var = PlayerPrefs.GetInt("PassHek");
        int var1 = PlayerPrefs.GetInt("LeaveDebraOffice");
        if (var == 1 && var1 != 1)
        {
            Pass.SetActive(true);
        }
        Screen.autorotateToLandscapeLeft = true;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

}
