using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBioLobby1 : MonoBehaviour
{
    public GameObject foreman;
    public GameObject photo;
    //public GameObject directionUnlocked;
    void Awake()
    {
        int var = PlayerPrefs.GetInt("ForeManLobby1");
        if (var == 1)
        {
            foreman.SetActive(false);
            GameObject varObject = GameObject.Find("Main Camera");
            varObject.GetComponent<TriggerWhenStart>().enabled = false;
            //directionUnlocked.SetActive(true);

        }


    }
    private void Update()
    {
        int var = PlayerPrefs.GetInt("PhotoFolder");
        if (var == 1 && photo != null)
        {
            //Also update Map...
            //They have the photos? If player has photos allow map access to snelgrove
            PlayerPrefs.SetInt("SG", 1);
            photo.SetActive(false);
            
        }
        else
        {
            photo.SetActive(true);
        }
    }
}
