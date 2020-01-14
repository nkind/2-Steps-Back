using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleGone : MonoBehaviour
{
   public void DrImpaGone()
    {
        PlayerPrefs.SetInt("DrImpa", 1);
    }
    //Testing Purpose
    public void DrImpaBack()
    {
        PlayerPrefs.SetInt("DrImpa", 0);
    }
    public void JanitorHSGone()
    {
        PlayerPrefs.SetInt("JanitorHS", 1);
    }
    //Testing Purpose
    public void JanitorHSBack()
    {
        PlayerPrefs.SetInt("JanitorHS", 0);
        Debug.Log("back");
    }
}
