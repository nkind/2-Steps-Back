using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HSMinLobbyCheck : MonoBehaviour
{
    public GameObject dr;
    private void Awake()
    {
        int var = PlayerPrefs.GetInt("DrMainLobby");
        if(var == 1)
        {
            GameObject varObject = GameObject.Find("Main Camera");
            varObject.GetComponent<TriggerWhenStart>().enabled = false;
            dr.SetActive(false);
        }
        PlayerPrefs.SetInt("DrMainLobby", 1);
    }

    public void DrImpaLobbyTalked()
    {
        PlayerPrefs.SetInt("DrMainLobby",1);
    }
    public void ResetAllPerfab()
    {
        PlayerPrefs.DeleteAll();
    }
}
